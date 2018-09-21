using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniMarket
{
    public partial class Accountant : Form
    {
        Budgets bud = new Budgets();
        MinimarketEntities5 db = new MinimarketEntities5();
        Label lb;
        int num;
        internal List<string> ItemQUn_0;
        public Accountant()
        {
            InitializeComponent();
            ItemQUn_0 = new List<string>();
        }

        private void Accountant_Load(object sender, EventArgs e)
        {
            var query = from p in db.Producs where p.ProductQty == 0 select new { p.ProductName };
            foreach (var item in query)
            {
                ItemQUn_0.Add(item.ProductName.ToString());
            }
            for (int i = 0; i < ItemQUn_0.Count; i++)
            {
                lb = new Label();
                lb.Text = ItemQUn_0[i];
                checkedListBox2.Items.Add(lb.Text);
            }

        }
        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            num = 0;
            foreach (object item in checkedListBox2.CheckedItems.OfType<string>().ToList())
            {
                num++;

            }

        }


        private void bt_update_Click(object sender, EventArgs e)
        {
            if (num == 1)
            {
                foreach (object item in checkedListBox2.CheckedItems.OfType<string>().ToList())
                {
                    updateProduct p=new updateProduct();
                    int index = checkedListBox2.Items.IndexOf(item);
                    checkedListBox2.Items.Remove(item);
                    p.Productname = ItemQUn_0[index];
                    p.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("You Should Choose only one item");
            }
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            if(tx_cate.Text!=""&&tx_DateEX.Text!=""&&tx_DateOfPro.Text!=""&&tx_importer.Text!=""&&tx_name.Text!=""&&tx_numbill.Text!=""&&tx_priceItem.Text!=""&&tx_productprice.Text!=""&&tx_qun.Text!="")
            {
                try
                {
                    portselling port = new portselling()
                    {
                        balance = int.Parse(tx_balance.Text),
                    phone_importer=int.Parse(tx_phone.Text),
                    address_importer=tx_address.Text,
                    name_importer=tx_importer.Text
                    };
                    Produc product = new Produc()
                    {
                        Buy_id=int.Parse(tx_numbill.Text),
                ProductPrice=float.Parse(tx_productprice.Text),
                ProductQty=int.Parse(tx_qun.Text),
                ProductCateg=tx_cate.Text,
                item_price=float.Parse(tx_priceItem.Text),
                name_importer=tx_importer.Text,
                Data_of_expiration=DateTime.Parse(tx_DateEX.Text),
                   ProductName=tx_name.Text,
                    };
                    db.Producs.Add(product);
                    db.SaveChanges();
                }
                catch(EntitySqlException m)
                {
                    MessageBox.Show(m.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int d;
            float total;
            switch (comboBox1.Text)
            {
                case "Daily":
                    {
                        d = 0;
                        dataGridView1.Rows[0].Cells[0].Value = bud.exports(d);
                        dataGridView1.Rows[0].Cells[1].Value = bud.imports(d);
                        total = bud.imports(d)-bud.exports(d) ;
                        rtb_profit.Text = "   " + total + " EG";
                        break;
                    }
                case "Weekly":
                    {
                        d = -7;
                        dataGridView1.Rows[0].Cells[0].Value = bud.exports(d);
                        dataGridView1.Rows[0].Cells[1].Value = bud.imports(d);
                        total = bud.imports(d) - bud.exports(d);
                        rtb_profit.Text = "   " +total + " EG";
                        break;
                    }
                case "Monthly":
                    {
                        d = -30;
                        dataGridView1.Rows[0].Cells[0].Value = bud.exports(d);
                        dataGridView1.Rows[0].Cells[1].Value = bud.imports(d);
                        total = bud.imports(d) - bud.exports(d);
                        rtb_profit.Text = "   " + total + " EG";
                        break;
                    }

            }
         
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            Login p = new Login();
            this.Dispose();
            p.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (num == 1)
            {
                foreach (object item in checkedListBox2.CheckedItems.OfType<string>().ToList())
                {
                    int index = checkedListBox2.Items.IndexOf(item);

                    var product = db.Producs.Find(ItemQUn_0[index]);
                    db.Producs.Remove(product);
                    db.SaveChanges();
                    checkedListBox2.Items.Remove(item);
                }
            }
            else
            {
                MessageBox.Show("You Should Choose only one item");
            }

        }
    }
}

       

 
    

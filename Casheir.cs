using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
namespace MiniMarket
{
    public partial class Casheir : Form
    {
        int NumSave;
        Product pro = new Product();
        Budgets cost = new Budgets();
        MinimarketEntities5 db;
        int idBill;
        float price;
        List<Single> priceItem;
         List<int> quantity;
        item Item = new item();
     Bill bill = new Bill();
        int itemCount;
        Accountant Acc = new Accountant();
        public Casheir()
        {
            InitializeComponent();
            db = new MinimarketEntities5();
            idBill = 0;
            priceItem = new List<float>();
            quantity = new List<int>();
            itemCount = 0;
            price = 0f;
            NumSave = 0;
        }

        private void Casheir_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'minimarketDataSet.Produc' table. You can move, or remove it, as needed.
            this.producTableAdapter.Fill(this.minimarketDataSet.Produc);
            cb_category.Text = "";
            cb_product.Text = "";
            label2.Text = "" + idBill;

        }

        private void but_save_Click(object sender, EventArgs e)
        {

            Add_Item();
            
        
        }

        private void Check_Quentity()
        { }

        private void button2_Click(object sender, EventArgs e)
        {
            tx_quantity.Text=cb_product.Text=cb_category.Text= "";
            idBill++;
            label2.Text = "" + idBill;
            itemCount = 0;
            listBox1.Items.Clear();
        }

        internal void Add_Item()
        {
            NumSave = 0;
            label3.Text = "";
            if (tx_quantity.Text != "" && cb_category.Text != "" && cb_product.Text != "")
            {
                try
                {
                    Item.billnum = idBill;
                    Item.item_name = cb_product.Text;
                    Item.itemQty = int.Parse(tx_quantity.Text);
                    int check = pro.Calculate_quantity(int.Parse(tx_quantity.Text), Item.item_name);
                    if (check == 1)
                    {
                        db.items.Add(Item);
                        db.SaveChanges();
                        Saving_item(Item);
                    }
                    if (check == 0)
                    {
                        db.items.Add(Item);
                        db.SaveChanges();
                        Saving_item(Item);
                        Acc.ItemQUn_0.Add(Item.item_name);
                    }
                    if (check == -1)
                    {
                        label3.ForeColor = Color.Red;
                        label3.Text = "The Quantity isnot available";
                    }
                    NumSave++;
                }

                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            else
            {
                label3.Text = "You should enter item";
            }
        }

        private void but_finish_Click(object sender, EventArgs e)
        {
            if (NumSave > 0)
            {
                try
                {
                    listBox1.Items.Clear();
                    bill.Idbill = idBill;
                    bill.SaleDate = DateTime.Today;
                    bill.SaleCountItem = itemCount;
                    bill.SaleTotal = cost.Cost_bill(priceItem, quantity);
                    db.Bills.Add(bill);
                    db.SaveChanges();
                    tx_quantity.Text = cb_product.Text = cb_category.Text = "";
                    listBox1.Items.Add("Total Cost :" + cost.Cost_bill(priceItem, quantity));
                    priceItem.Clear();
                    quantity.Clear();
                }
                catch (Exception n)
                {
                    MessageBox.Show(n.Message);
                }
            }
            else
            {
                label3.ForeColor = Color.Red;
                label3.Text = "You Should First enter item";
               
            }
        }
private void Saving_item(item item)
        {
            try
            {
                quantity.Add(int.Parse(tx_quantity.Text));
                tx_quantity.Text = cb_product.Text = cb_category.Text = "";
                var Sale = from p in db.Producs where p.ProductName == item.item_name select new { p.item_price };
                foreach (var i in Sale)
                {
                    price = i.item_price;
                }
                priceItem.Insert(itemCount, price);
                itemCount++;
            }
    catch(Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

private void groupBox1_Enter(object sender, EventArgs e)
{

}

private void button1_Click(object sender, EventArgs e)
{
    Login p = new Login();
    this.Dispose();
    p.ShowDialog();

}
    


    }
}

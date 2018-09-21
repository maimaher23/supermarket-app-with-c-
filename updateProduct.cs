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
    public partial class updateProduct : Form
    {
        internal string Productname;
        MinimarketEntities5 db = new MinimarketEntities5();
        public updateProduct()
        {
            InitializeComponent();
        }

        private void updateProduct_Load(object sender, EventArgs e)
        {

        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            if(Productname!=null)
            {
                if (tx_DateEX.Text != "" && tx_DateOfPro.Text != "" && tx_importer.Text != "" && tx_numbill.Text != "" && tx_priceItem.Text != "" && tx_productprice.Text != "" && tx_qun.Text != "")
                {
                    try
                    {
                        var product = db.Producs.Find(Productname);
                        product.Buy_id = int.Parse(tx_numbill.Text);
                        product.Data_of_expiration = DateTime.Parse(tx_DateEX.Text);
                        product.Data_of_production = DateTime.Parse(tx_DateOfPro.Text);
                        product.item_price = float.Parse(tx_priceItem.Text);
                        product.name_importer = tx_importer.Text;
                        product.ProductQty = int.Parse(tx_qun.Text);
                        product.ProductPrice = float.Parse(tx_productprice.Text);
                        db.SaveChanges();
                    }
                    catch (EntitySqlException b)
                    {
                        MessageBox.Show(b.Message);
                    }
                    this.Dispose();
                }
            }
           
        }

      
    }
}

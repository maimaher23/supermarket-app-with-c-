using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace MiniMarket
{
    public partial class Login : Form
    {
        MinimarketEntities5 db;
       bool clicked;
        string position;
        public Login()
        {
            InitializeComponent();
            db = new MinimarketEntities5();
          
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text != "" && txt_password.Text != "")
            {
                try
                {
                    var query = from p in db.employees
                                where p.ID_name == txt_ID.Text && p.password == txt_password.Text
                                select new { p.position };

                    foreach (var item in query)
                    {
                        position = item.position;
                    }
                        clicked = true;
                        Login_Shown(sender, e);
                       
                }
                catch (Exception s)
                {
                    lb.Text = "Incorrect user name or password";
                    MessageBox.Show(s.Message);
                }
               
            }
            else {
                lb.Text = "An empty field";
            
            
            }
            
          

        }

        private void Login_Shown(object sender, EventArgs e)
        {
            if (clicked==true)
            {

                if (position == "manager   ")
              {
                 Manager p = new Manager();
                 p.Location = this.Location;
                 p.Width = 685;
                 p.MinimumSize = new Size(685, 593);
                 p.MaximumSize = new Size(685, 593);
                 this.Hide();
                 p.ShowDialog();
                }
              else if (position == "casheir   ")
                 {
                  
                     Casheir p = new Casheir();
                     p.Location = this.Location;
                     p.Width =1096;
                     p.Height = 547;
                     p.MinimumSize = new Size(1096, 547);
                     p.MaximumSize = new Size(1096, 547);
                     this.Hide();
                     p.ShowDialog();
                 }

                else if (position == "accountant")
                        {
                            Accountant p = new Accountant();
                            p.Location = this.Location;
                            p.Width = 1315;
                            p.Height = 556;
                            this.Hide();
                            p.ShowDialog();
                        }
                    
                }

            }

        
        private void Login_Load(object sender, EventArgs e)
        {
            
                     
              

        }


    }

}

      



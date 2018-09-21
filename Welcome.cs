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
    public partial class welcome : Form
    {

        public welcome()
        {

            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width += 1;
            this.Opacity -= .003;
            if (panel1.Width==330)
            {
                timer1.Enabled = false;
             Login p = new Login();
                p.Location = this.Location;
                p.Width = 625;
                p.Height = this.Height;
                try {
                    this.Hide();
                    p.ShowDialog();
                }
                catch(Exception n)
                {
                    MessageBox.Show(n.Message);
                }
                
            }
          
        }

     

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
           
        }


    }

   
    }


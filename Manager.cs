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
    public partial class Manager : Form
    {
      
        bool clicked;
        int d;
        MinimarketEntities5 db = new MinimarketEntities5();
        Budgets bud = new Budgets();
        public Manager()
        {
            InitializeComponent();
          

        }

        private void managerinterface_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'minimarketDataSet2.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.minimarketDataSet2.employee);
           
            clicked = false;
           
        }

      

        private void but_check_Click(object sender, EventArgs e)
        {
           
            if(clicked==false)
            {
                this.Width = 1293;
                this.MinimumSize = new Size(1293, 593);
                this.MaximumSize = new Size(1293, 593);
                clicked = true;
                but_check.Text = "Less";
            }
            else
            {
                this.Width = 685;
                this.MinimumSize = new Size(685, 593);
                this.MaximumSize = new Size(685, 593);
                clicked = false;
                but_check.Text = "More";
            }
        }

        private void but_add_Click(object sender, EventArgs e)
        {
            if (tx_address.Text != "" && tx_age.Text != "" && tx_name.Text != "" && tx_password.Text != "" && tx_position.Text != "" && tx_salary.Text != "" && tx_id.Text != "")
            {
                try
                {
                    employee emp = new employee()
                    {

                        address = tx_address.Text,
                        age = int.Parse(tx_age.Text),
                        ID_name = tx_id.Text,
                        password = tx_password.Text,
                        name = tx_name.Text,
                        salary = Single.Parse(tx_salary.Text),
                        position = tx_position.Text

                    };
                    db.employees.Add(emp);
                    db.SaveChanges();
                    tx_address.Text = tx_age.Text = tx_name.Text = tx_password.Text = tx_position.Text = tx_salary.Text = tx_id.Text = "";
                }

                catch (Exception r)
                {
                    MessageBox.Show(r.Message);
                }
            }
            else
            {
                lb_validated.Text = "An empty field";
            }

        }

        private void but_update_Click(object sender, EventArgs e)
        {
            if (tx_address.Text != "" && tx_age.Text != "" && tx_name.Text != "" && tx_password.Text != "" && tx_position.Text != "" && tx_salary.Text != "" && tx_id.Text != "")
            {
                try
                {
                    var emp = db.employees.Find(comboBox1.SelectedValue);
                    emp.address = tx_address.Text;
                    emp.age = int.Parse(tx_age.Text);
                    emp.ID_name = tx_id.Text;
                    emp.position = tx_position.Text;
                    emp.salary = Single.Parse(tx_salary.Text);
                    emp.name = tx_name.Text;
                    emp.password = tx_password.Text;
                    tx_address.Text = tx_age.Text = tx_name.Text = tx_password.Text = tx_position.Text = tx_salary.Text = tx_id.Text = "";
                   
                }
                catch(EntitySqlException r)
                {
                    MessageBox.Show(r.Message);
                }
            }
            else
            {
               lb_validated. Text = "An empty field";
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                var emp = db.employees.Find(comboBox1.SelectedValue);
                tx_address.Text = emp.address;
                tx_age.Text = emp.age.ToString();
                tx_id.Text = emp.ID_name;
                tx_position.Text = emp.position;
                tx_salary.Text = emp.salary.ToString();
                tx_name.Text = emp.name;
                tx_password.Text = emp.password;
            }catch(EntitySqlException r)
            {
                MessageBox.Show(r.Message);
            }
        }

   

      private void cb_search_SelectedIndexChanged(object sender, EventArgs e)
      {
        
      }

      private void but_del_Click(object sender, EventArgs e)
      {

          if (MessageBox.Show("You want to delete this employee ","Attention !",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning)==DialogResult.Yes)
          {
              if (tx_address.Text != "" && tx_age.Text != "" && tx_name.Text != "" && tx_password.Text != "" && tx_position.Text != "" && tx_salary.Text != "" && tx_id.Text != "")
              {
                  try
                  {
                      var emp = db.employees.Find(comboBox1.SelectedValue);
                      db.employees.Remove(emp);
                      db.SaveChanges();
                      tx_address.Text = tx_age.Text = tx_name.Text = tx_password.Text = tx_position.Text = tx_salary.Text = tx_id.Text = "";
                      comboBox1.SelectedText = "";
                  }
                  catch(EntitySqlException r)
                  {
                      MessageBox.Show(r.Message);
                  }
                 
              }
              else 
              {
                  lb_validated.Text = "An empty field";
              }
          }
      }

      private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
      {
          float total;
          switch (comboBox2.Text)
          {
              case "Daily":
                  {
                      d = 0;
                      dataGridView1.Rows[0].Cells[0].Value = bud.exports(d);
                      dataGridView1.Rows[0].Cells[1].Value = bud.imports(d);
                      total = bud.imports(d) - bud.exports(d);
                      rtb_profit.Text = "   " + total + " EG";
                      break;
                  }
              case "Weekly":
                  {
                      d = -7;
                      dataGridView1.Rows[0].Cells[0].Value = bud.exports(d);
                      dataGridView1.Rows[0].Cells[1].Value = bud.imports(d);
                      total = bud.imports(d) - bud.exports(d);
                      rtb_profit.Text = "   " + total + " EG";
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

      private void button2_Click(object sender, EventArgs e)
      {
          Login p = new Login();
          this.Dispose();
          p.ShowDialog();
      }

      private void fillByToolStripButton_Click(object sender, EventArgs e)
      {
          try
          {
              this.employeeTableAdapter.FillBy(this.minimarketDataSet2.employee);
          }
          catch (System.Exception ex)
          {
              System.Windows.Forms.MessageBox.Show(ex.Message);
          }

      }

      private void textBox1_TextChanged(object sender, EventArgs e)
      {

      }
      

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace MiniMarket
  
{
    class Budgets
    {
        MinimarketEntities5 db = new MinimarketEntities5();
        DateTime date;
        
        public Budgets()
        {
           
        }
      
        internal Single exports(int duration)
        {
            Single total = 0;
            for (int i =duration ; i<= 0; i++)
            {
                date = DateTime.Today.AddDays(i);
             
                    var query = from p in db.Buybills where p.BuyDate == date select new { p.BuyTotal };
                    foreach (var items in query)
                    {
                        total +=items.BuyTotal;

                    }
                
            }
            return total;
        }

        internal Single imports(int duration)
        {
            Single total = 0;
            for (int i = duration; i <= 0; i++)
            {
                date = DateTime.Today.AddDays(i);
               
                    var query = from p in db.Bills where p.SaleDate == date select new { p.SaleTotal };

                    foreach (var items in query)
                    {
                        total +=items.SaleTotal;
                    }
              
            }
            return total;
        }
       internal Single Cost_bill(List<float> price,List<int> quantity)
        {
          
           float totalsale = 0f;
            try
            {
                for (int i = 0; i < price.Count; i++)
                {
                    totalsale += (quantity[i] * price[i]);
                }
               
            }
           catch (Exception e){
               MessageBox.Show(e.Message);
            }
            return totalsale;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD_GUI_assignment.Model
{
    public class AccountModel
    {
        List<Tuple<DateTime,double>> _balanceList = new List<Tuple<DateTime, double>>();

        public AccountModel(string name, double balance = 0)
        {
            Name = name;
            Balance = balance;
        }



        public String Name { get; set; }
        

        public double Balance { get; set; }
       

    }

} 

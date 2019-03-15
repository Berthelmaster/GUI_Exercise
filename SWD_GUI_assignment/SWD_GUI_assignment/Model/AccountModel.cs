using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD_GUI_assignment.Model
{
    class AccountModel
    {
        private string _name;
        private double _balance;

        public AccountModel(string name, double balance = 0)
        {
            _name = name;
            _balance = balance;
        }

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

    }

} 

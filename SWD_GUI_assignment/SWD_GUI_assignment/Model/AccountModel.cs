using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD_GUI_assignment.Model
{
    public class AccountModel
    {
        ObservableCollection<Tuple<DateTime,double>> _balanceList = new ObservableCollection<Tuple<DateTime, double>>();

        

        public AccountModel(string name, double balance = 0)
        {
            Name = name; 
            ChangeBalance(balance);
        }

        public ObservableCollection<Tuple<DateTime, double>> BalanceList
        {
            get { return _balanceList; }
            set { }
        }

        public String Name { get; set; }
        
        public double Balance { get; set; }

        public void ChangeBalance(double balance)
        {
            DateTime currentDateTime = new DateTime();
            currentDateTime = DateTime.Now;
            Tuple<DateTime, double> balanceEntry = new Tuple<DateTime, double>(currentDateTime, balance);

            _balanceList.Add(balanceEntry);

            Balance += balance;
        }
    }

} 

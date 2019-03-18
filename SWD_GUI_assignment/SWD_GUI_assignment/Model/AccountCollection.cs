using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Xml.Serialization;

namespace SWD_GUI_assignment.Model
{
    public class AccountCollection: INotifyPropertyChanged
    {
        private ObservableCollection<AccountModel> debtors = new ObservableCollection<AccountModel>();

        public AccountCollection()
        {
            debtors = new ObservableCollection<AccountModel>();
            debtors.Add(new AccountModel("Poul Poulsen", 400));
            debtors.Add(new AccountModel("Jens Jensen", -200));
        }




        public ObservableCollection<AccountModel> Debtors
        {
            get
            {
                return debtors;
            }
        }

        public void AddNewDebter(AccountModel acc)
        {
            debtors.Add(acc);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
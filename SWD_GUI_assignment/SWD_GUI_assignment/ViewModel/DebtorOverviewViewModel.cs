using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using SWD_GUI_assignment.Model;

namespace SWD_GUI_assignment.ViewModel
{
   public class DebtorOverviewViewModel
   {
       public AccountModel _account;
        public DebtorOverviewViewModel(ref AccountModel acccount)
        {
            _account = acccount;
        }

        private ICommand _AddValueCommand;
        public ICommand AddValueCommand
        {
            get
            {
                return _AddValueCommand ?? (_AddValueCommand = new RelayCommand(AddValue_OnClick));
            }
        }

        public String BalanceList
        {
            get
            {
                _account.BalanceList[]
                return null;
            }
            set { }
        }

        public String Name
        {
            get => _account.Name;  
            set
            {
                if (value != _account.Name)
                {
                    _account.Name = value;
                    //OnPropertyChanged();
                }
            }
        }



        private void AddValue_OnClick()
        {
            //_account.ChangeBalance();
        }


    }
}

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
       public AccountCollection accounts;
        public DebtorOverviewViewModel(ref AccountCollection accs)
        {
            accounts = accs;
        }

        private ICommand _CloseBtnCommand;
        public ICommand CloseBtnCommand
        {
            get
            {
                return _CloseBtnCommand ?? (_CloseBtnCommand = new RelayCommand(CloseBtn_OnClick));
            }
        }

        private void CloseBtn_OnClick()
        {

        }


    }
}

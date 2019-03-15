using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using SWD_GUI_assignment.Annotations;
using SWD_GUI_assignment.Model;

namespace SWD_GUI_assignment.ViewModel
{
    public class AddDebtorViewModel: INotifyPropertyChanged
    {
        private AccountCollection _accs;

        public AddDebtorViewModel(ref AccountCollection accs)
        {
            _accs = accs;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        AccountModel AccountModel=new AccountModel(null);

        public String Name
        {
            get => AccountModel.Name;
            set
            {
                if (value != AccountModel.Name)
                {
                    AccountModel.Name = value;
                    OnPropertyChanged();
                }
            }
        }
        public double Balance
        {
            get => AccountModel.Balance;
            set
            {
                if (value != AccountModel.Balance)
                {
                    AccountModel.ChangeBalance(value);
                    OnPropertyChanged();
                }
            }
        }

        public void AddDebter_OnClick()
        {
            if (AccountModel != null)
            {
                _accs.AddNewDebter(AccountModel);
            }
        }

        public void CloseApplication_OnClick()
        {
            //this.Close;
        }


        private ICommand _AddDebtorCommand;

        public ICommand AddDebtorCommand
        {
        
            get
            {
                return _AddDebtorCommand ?? (_AddDebtorCommand = new RelayCommand(AddDebter_OnClick));
            }
        
        }

        private ICommand _CloseCommand;

        public ICommand CloseCommand
        {

            get
            {
                return _CloseCommand ?? (_CloseCommand = new RelayCommand(CloseApplication_OnClick));
            }

        }


    }

} 



using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using SWD_GUI_assignment.Annotations;
using SWD_GUI_assignment.Model;

namespace SWD_GUI_assignment.ViewModel
{
   public class DebtorOverviewViewModel : INotifyPropertyChanged
   {

       public event PropertyChangedEventHandler PropertyChanged;

       [NotifyPropertyChangedInvocator]
       protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
       {
           PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
       }

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


        private void AddValue_OnClick()
        {
           _account.ChangeBalance(double.Parse(ValueToAdd));
           OnPropertyChanged();
        }

        private string _valueToAdd;

        public string ValueToAdd
        {
            get { return _valueToAdd; }
            set
            {
                _valueToAdd = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Tuple<DateTime, double>> BalanceList
        {
            get => _account.BalanceList;

        }

        public String Name
        {
            get => _account.Name;
        }




    }
}

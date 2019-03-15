using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using SWD_GUI_assignment.Model;

namespace SWD_GUI_assignment.ViewModel
{
	public class MainWindowViewModel: INotifyPropertyChanged
	{
        ObservableCollection<AccountModel> debtors;

        public MainWindowViewModel()
        {
            debtors = new ObservableCollection<AccountModel>();
            debtors.Add(new AccountModel("Apollo", 1000000));
            debtors.Add(new AccountModel("Jens Jensen", -200));
            CurrentDebtor = debtors[0];
        }


        AccountModel currentDebtor = null;
        public AccountModel CurrentDebtor
        {
            get { return currentDebtor; }
            set
            {
                if (currentDebtor != value)
                {
                    currentDebtor = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ObservableCollection<AccountModel> Debtors
        {
            get
            {
                return debtors;
            }
        }

        public void AddNewDebtor()
        {
            debtors.Add(new AccountModel("Ny Debtor",0));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

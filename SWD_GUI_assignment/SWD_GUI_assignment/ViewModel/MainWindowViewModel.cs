using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using BMICalculator.ViewModel;
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

        // On Proberty Changed
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //Commands
        public void AddDebter_OnClick()
        { 
            AddDebtor addDebtorWin = new AddDebtor();
            addDebtorWin.Show();
        }

        public void OverView_OnClick()
        {
            DebtorOverview overViewWin = new DebtorOverview(CurrentDebtor);
            overViewWin.Show();
        }

        private ICommand _OpenAddDebterCommand;

        public ICommand OpenAddDebterCommand
        {
            get
            {
                return _OpenAddDebterCommand ?? (_OpenAddDebterCommand = new RelayCommand(AddDebter_OnClick));
            }
        }

        private ICommand _OpenOverviewCommand;
        public ICommand OpenOverviewCommand
        {
            get
            {
                return _OpenOverviewCommand ?? (_OpenOverviewCommand = new RelayCommand(OverView_OnClick));
            }
        }

    }
}

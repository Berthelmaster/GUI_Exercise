using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Windows.Media.Animation;
using SWD_GUI_assignment.Model;

namespace SWD_GUI_assignment.ViewModel
{
	public class MainWindowViewModel: INotifyPropertyChanged
	{
        public AccountCollection accounts = new AccountCollection();

        public MainWindowViewModel()
        {
         CurrentDebtor = accounts.Debtors[0];
        }

       public AccountCollection Accounts
       {
           get { return accounts; }
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

        // On Proberty Changed
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //Commands

        private ICommand _OpenAddDebterCommand;

        public ICommand OpenAddDebterCommand
        {
            get
            {
                return _OpenAddDebterCommand ?? (_OpenAddDebterCommand = new RelayCommand(()=> {
                    var vm = new AddDebtorViewModel(ref accounts);



                    var addDebtorWin = new AddDebtor();
                    addDebtorWin.Show();
                }));
            }
        }

        private ICommand _OpenOverviewCommand;
        public ICommand OpenOverviewCommand
        {
            get
            {
                return _OpenOverviewCommand ?? (_OpenOverviewCommand = new RelayCommand(()=>
                {
                    var vm = new DebtorOverviewViewModel(ref currentDebtor);

                    DebtorOverview overViewWin = new DebtorOverview(CurrentDebtor);
                    overViewWin.Show();
                }));
            }
        }

    }
}

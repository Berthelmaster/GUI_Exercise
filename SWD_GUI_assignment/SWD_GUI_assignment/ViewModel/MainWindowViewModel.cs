using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace SWD_GUI_assignment.ViewModel
{
	public class MainWindowViewModel: INotifyPropertyChanged
	{
        ObservableCollection<AccountModel> debtors;

        public MainWindowViewModel()
        {
            debtors = new ObservableCollection<AccountModel>();
            debtors.Add(new Agent("001", "Nina", "Assassination", "UpperVolta"));
            debtors.Add(new Agent("007", "James Bond", "Martinis", "North Korea"));
            CurrentDebtor = debtors[0];
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

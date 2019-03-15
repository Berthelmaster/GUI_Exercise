using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SWD_GUI_assignment.Annotations;
using SWD_GUI_assignment.Model;

namespace SWD_GUI_assignment.ViewModel
{
    public class AddDebtorViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        AccountModel AccountModel=new AccountModel(null, 0);

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
                    AccountModel.Balance = value;
                    OnPropertyChanged();
                }
            }
        }


    }

} 



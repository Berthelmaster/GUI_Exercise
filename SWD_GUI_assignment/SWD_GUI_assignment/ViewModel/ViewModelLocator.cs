using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWD_GUI_assignment.Model;
using SWD_GUI_assignment.ViewModel;

namespace SWD_GUI_assignment.ViewModel
{
    public class ViewModelLocator
    {

        /* public AddDebtorViewModel AddDebtorViewModel
         {
             get { return new AddDebtorViewModel(); }
         }
         */

        //public DebtorOverviewViewModel DebtorOverviewViewModel
        //{
        //    get { return new DebtorOverviewViewModel(); }
        //}

        public MainWindowViewModel MainWindowViewModel
        {
            get { return new MainWindowViewModel();}
        }

    }
}

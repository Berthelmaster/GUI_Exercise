using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SWD_GUI_assignment.Model;

namespace SWD_GUI_assignment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class DebtorOverview : Window
    {
        private AccountModel _account;

        public DebtorOverview(AccountModel account)
        {
            //_account = account;
            //Name.Content = _account.Name; 
            InitializeComponent();
        }

        //private void AddButton_Click(object sender, RoutedEventArgs e)
        //{
        //    _account.ChangeBalance(double.Parse(Value.Text));
        //}

        //private void CloseButton_Click(object sender, RoutedEventArgs e)
        //{
        //    this.Close();
        //}
    }
}

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
using SWD_GUI_assignment.ViewModel;

namespace SWD_GUI_assignment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnForward_OnClick(object sender, RoutedEventArgs e)
        {
            if (lbxDebtors.SelectedIndex < lbxDebtors.Items.Count - 1)
                lbxDebtors.SelectedIndex = ++lbxDebtors.SelectedIndex;
        }

        private void BtnBack_OnClick(object sender, RoutedEventArgs e)
        {
            if (lbxDebtors.SelectedIndex > 0)
                lbxDebtors.SelectedIndex = --lbxDebtors.SelectedIndex;
        }

        
    }
}

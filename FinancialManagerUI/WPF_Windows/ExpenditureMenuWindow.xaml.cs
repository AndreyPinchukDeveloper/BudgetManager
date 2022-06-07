using FinancialManagerUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using System.Windows.Shapes;

namespace FinancialManagerUI
{
    /// <summary>
    /// Interaction logic for ExpenditureMenuWindow.xaml
    /// </summary>
    public partial class ExpenditureMenuWindow : Window
    {
        public ExpenditureMenuWindow()
        {
            InitializeComponent();
            DataContext = new ViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

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
using System.Data.SqlClient;
using System.Configuration;

namespace FinancialManagerUI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Increment_Click(object sender, RoutedEventArgs e)
        {
            RecieptMenuWindow recieptMenuWindow = new RecieptMenuWindow();
            recieptMenuWindow.Show();
        }

        private void Decrement_Click(object sender, RoutedEventArgs e)
        {
            ExpenditureMenuWindow expenditureMenuWindow = new ExpenditureMenuWindow();
            expenditureMenuWindow.Show();
        }

        private void History_Click(object sender, RoutedEventArgs e)
        {
            HistoryWindow historyWindow = new HistoryWindow();
            historyWindow.Show();
        }
    }
}

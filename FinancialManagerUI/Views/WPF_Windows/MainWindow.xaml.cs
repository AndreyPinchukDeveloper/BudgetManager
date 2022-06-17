using System.Windows;

namespace FinancialManagerUI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            BudgetManagerLibrary.GlobalConfig.InitializeConnections(BudgetManagerLibrary.DatabaseType.Sql);//replace Sql to text to check how it work
            InitializeComponent();
        }
        //TODO - value of my purse from database

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

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
    }
}

using System.Windows;

namespace FinancialManagerUI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            BudgetManagerLibrary.GlobalConfig.InitializeConnections(BudgetManagerLibrary.DatabaseType.Sql);
            InitializeComponent();
        }
        //TODO - value of my purse from database
    }
}

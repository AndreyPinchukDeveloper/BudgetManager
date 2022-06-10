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
using BudgetManagerLibrary.Models;
using BudgetManagerLibrary;
using BudgetManagerLibrary.DataAccess;

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
            //TODO-if true add this data to basedate
            if (ValidateForm())
            {
                MoneyModel model = new MoneyModel(amountToDecrement.Text);
                SqlConnector connector = new SqlConnector();
                connector.CreateExpenditureOrReciept(model);
                foreach (IDataConnection database in GlobalConfig.Connections)
                {
                    database.CreateExpenditureOrReciept(model);
                }

                amountToDecrement.Text = "0";
                expenditureNotes.Text = "";
                cbExpenditures.Text = "";
            }
            else
            {
                MessageBox.Show("This form has invalid information, please check it and try again !");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            decimal amountOfMoney = 0;
            bool validAmountToIncrement = decimal.TryParse(amountToDecrement.Text, out amountOfMoney);

            if (!validAmountToIncrement)//we need only negative value and only numbers
            {
                output = false;
            }
            return output;
        }
    }
}

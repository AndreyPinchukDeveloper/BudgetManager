using FinancialManagerUI.ViewModels;
using System.Windows;
using BudgetManagerLibrary.Models;
using BudgetManagerLibrary;

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
            DataContext = new MainWindowViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //TODO-if true add this data to basedate
            if (ValidateForm())
            {
                MoneyModel model = new MoneyModel(amountToDecrement.Text, cbExpenditures.Text, expenditureNotes.Text);

                GlobalConfig.Connection.CreateChange(model);

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

        private void AddYourOwnCategory_Click(object sender, RoutedEventArgs e)
        {
            string newName = addNewCategory.Text;
            if (ValidateForNewCategory(newName))
            {
                ComboBoxDataAccess comboDataAccess = new ComboBoxDataAccess();
                comboDataAccess.listOfExpenditures.Add(newName);
                DataContext = new MainWindowViewModel(comboDataAccess); 
            }
            addNewCategory.Text = "";
        }

        private bool ValidateForNewCategory(string newCategory)
        {
            switch (newCategory)
            {
                case "":
                    MessageBox.Show("Please, enter the correct name.");
                    return false;
                case null:
                    return false;
                default:
                    return true;
            }
        }
    }
}

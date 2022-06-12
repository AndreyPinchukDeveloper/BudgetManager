using BudgetManagerLibrary;
using BudgetManagerLibrary.DataAccess;
using BudgetManagerLibrary.Models;
using FinancialManagerUI.ViewModels;
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
using System.Windows.Shapes;

namespace FinancialManagerUI
{
    /// <summary>
    /// Interaction logic for RecieptMenuWindow.xaml
    /// </summary>
    public partial class RecieptMenuWindow : Window
    {
        
        public RecieptMenuWindow()
        {
            InitializeComponent();
            DataContext = new ViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //TODO-if true add this data to basedate
            if (ValidateForm())
            {
                MoneyModel model = new MoneyModel(amountToIncrement.Text, cbReciepts.Text, recieptNotes.Text);
                
                GlobalConfig.Connection.CreateChange(model);

                amountToIncrement.Text = "0";
                recieptNotes.Text = "";
                cbReciepts.Text = "";

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
            
            bool validAmountToIncrement = decimal.TryParse(amountToIncrement.Text, out amountOfMoney);

            if (!validAmountToIncrement)//we need only positive value and only numbers
            {
                output = false;
            }
            
            if (amountToIncrement.Text=="" && amountToIncrement.Text==null)
            {
                output = false;
            }
            return output;
        }
    }
}

using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetManagerLibrary.Models;
using BudgetManagerLibrary;

namespace FinancialManagerUI.ViewModels
{
    public class ViewModel
    {
        public BindableCollection<MoneyModel> Expenditures { get; set; }
        public BindableCollection<MoneyModel> Reciepts { get; set; }

        public ViewModel()
        {
            ComboBoxDataAccess da = new ComboBoxDataAccess();
            Expenditures = new BindableCollection<MoneyModel>(da.GetRecieptList(da.listOfExpenditures.Count, da.listOfExpenditures, da.listOfReciepts.Count));
            Reciepts = new BindableCollection<MoneyModel>(da.GetRecieptList(da.listOfReciepts.Count, da.listOfReciepts, da.listOfReciepts.Count));
        }
        public ViewModel(ComboBoxDataAccess comboBoxData)
        {
            Expenditures = new BindableCollection<MoneyModel>(comboBoxData.GetRecieptList(comboBoxData.listOfExpenditures.Count, comboBoxData.listOfExpenditures, comboBoxData.listOfReciepts.Count));
            Reciepts = new BindableCollection<MoneyModel>(comboBoxData.GetRecieptList(comboBoxData.listOfReciepts.Count, comboBoxData.listOfReciepts, comboBoxData.listOfReciepts.Count));
        }
    }
}

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
            DataAccess da = new DataAccess();
            Expenditures = new BindableCollection<MoneyModel>(da.GetRecieptList(da.listOfExpenditures.Count, da.listOfExpenditures, da.listOfReciepts.Count));
            Reciepts = new BindableCollection<MoneyModel>(da.GetRecieptList(da.listOfReciepts.Count, da.listOfReciepts, da.listOfReciepts.Count));
        }
    }
}

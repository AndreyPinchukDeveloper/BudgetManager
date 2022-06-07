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
        //public BindableCollection<ExpendituresCategoryModel> Expenditures { get; set; }
        public BindableCollection<RecieptsCategoryModel> Reciepts { get; set; }

        public ViewModel()
        {
            DataAccess da = new DataAccess();
            //Expenditures = new BindableCollection<ExpendituresCategoryModel>();
            Reciepts = new BindableCollection<RecieptsCategoryModel>(da.GetRecieptList());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagerLibrary
{
    public class MoneyModel
    {
        public decimal ValueOfMoney { get; set; }
        public string NameofChange { get; set; }

        /*public List<RecieptsCategoryModel> TypeOfReciept { get; set; } = new List<RecieptsCategoryModel>();//список типа покупок, машина, продукты
        public List<ExpendituresCategoryModel> TypeOfExpenditure { get; set; } = new List<ExpendituresCategoryModel>();*/
    }
}

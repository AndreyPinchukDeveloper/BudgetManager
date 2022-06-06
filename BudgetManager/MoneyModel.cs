using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManager
{
    public class MoneyModel
    {
        public decimal StartValueOfMoney { get; set; }//при первом старте нужно задать, сколько денег есть изначально
        public List<RecieptsCategoryModel> TypeOfReciept { get; set; } = new List<RecieptsCategoryModel>();//список типа покупок, машина, продукты
        public List<ExpendituresCategoryModel> TypeOfExpenditure { get; set; } = new List<ExpendituresCategoryModel>();
        public string NameOfExpenditure { get; set; }//название расхода
        public string NameOfReciept { get; set; }// название дохода
        public decimal ValueToChange { get; set; }// это значение будет icrement or decrement our value of money
    }
}

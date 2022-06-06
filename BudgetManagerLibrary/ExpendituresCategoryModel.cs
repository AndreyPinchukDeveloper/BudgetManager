using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagerLibrary
{
    public class ExpendituresCategoryModel
    {
        public string NameOfExpenditure { get; set; }
        public decimal ValueToDecrement{ get; set; }
        public string NotesForExpenditure { get; set; }
    }
}

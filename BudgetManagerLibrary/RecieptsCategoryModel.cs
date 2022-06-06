using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagerLibrary
{
    public class RecieptsCategoryModel
    {
        public List<string> NameOfRecieptCategory = new List<string>()
        {
            ""
        };
        public string NameOfReciept { get; set; }
        public decimal ValueToIncrement { get; set; }
        public string NotesForReciept { get; set; }
    }
}

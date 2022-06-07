using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagerLibrary.Models
{
    public class RecieptsCategoryModel
    {
        public string NameOfReciept { get; set; }
        public decimal ValueToIncrement { get; set; }
        public string NotesForReciept { get; set; }
        public string FullName 
        {
            get { return NameOfReciept; }
        }
    }
}

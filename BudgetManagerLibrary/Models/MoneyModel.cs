using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagerLibrary.Models
{
    public class MoneyModel
    {
        /// <summary>
        /// The unique identifier for the money
        /// </summary>
        public int Id { get; set; }
        public decimal ValueOfMoney { get; set; }
        public string NameofChange { get; set; }
        public string Note { get; set; }
    }
}

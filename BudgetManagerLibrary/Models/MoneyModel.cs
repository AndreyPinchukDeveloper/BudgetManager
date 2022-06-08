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
        public string NameOfChange { get; set; }
        public string Note { get; set; }
        public string FullName
        {
            get { return NameOfChange; }
        }
        public MoneyModel()
        {

        }
        public MoneyModel(string valueOfMoney, string nameOfChange, string note)
        {
            NameOfChange = nameOfChange;
            Note = note;

            decimal amountOfMoney = 0;
            decimal.TryParse(valueOfMoney, out amountOfMoney);
            ValueOfMoney = amountOfMoney;
        }
        public MoneyModel(string valueOfMoney)
        {
            decimal amountOfMoney = 0;
            decimal.TryParse(valueOfMoney, out amountOfMoney);
            ValueOfMoney = amountOfMoney;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetManagerDB.Context.Entityes.Base;

namespace BudgetManagerDB.Entities
{
    [Column(TypeName = "decimal(18,2)")]
    public class PersonalBudget : Entity
    {
        public int Amount { get; set; }
        public int Change { get; set; }
        public string? NameOfChange { get; set; }
        public string? Note { get; set; }
    }
}

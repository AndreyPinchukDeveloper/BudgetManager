using BudgetManagerDB.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagerDB.Context
{
    /// <summary>
    /// Structure of base date
    /// </summary>
    public class BudgetDB:DbContext
    {
        public DbGet<PersonalBudget> PersonalBudget { get; set; }

        public DbGet<Category> Categories { get; set; }

        public BudgetDB(DbContextOptions<BudgetDB> options) : base(options) { }
    }
}

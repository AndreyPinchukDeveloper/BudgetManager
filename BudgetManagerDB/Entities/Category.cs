using BudgetManagerDB.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagerDB.Entities
{
    public class Category : Entity
    {
        public virtual ICollection<Category> Categories { get; set; }//use virtual for first load don't download data here only if we call it
    }
}

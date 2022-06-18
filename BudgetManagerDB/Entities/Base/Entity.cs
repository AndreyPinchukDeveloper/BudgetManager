using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagerDB.Entities.Base
{
    /// <summary>
    /// base entity for all db classes
    /// </summary>
    public abstract class Entity
    {
        public int Id { get; set; }//use long or Guid(string for first key) for very long address
    }

}
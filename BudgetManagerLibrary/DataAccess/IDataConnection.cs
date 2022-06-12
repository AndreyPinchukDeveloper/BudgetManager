using BudgetManagerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagerLibrary.DataAccess
{
    public interface IDataConnection
    {
        //TODO - code here
        MoneyModel CreateChange(MoneyModel model);
        
    }
}

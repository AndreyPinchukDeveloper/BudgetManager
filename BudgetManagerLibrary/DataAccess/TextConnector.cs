using BudgetManagerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        public MoneyModel CreateChange(MoneyModel model)
        {
            model.Id = 1;
            return model;
        }

        /*public MoneyModel CreateExpenditureOrReciept(MoneyModel model)
        {
            throw new NotImplementedException();
        }*/
    }
}

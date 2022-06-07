using BudgetManagerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagerLibrary
{
    public class TextConnection : IDataConnection
    {
        //TODO - Wire up(connect) MoneyModel for text files
        public MoneyModel CreateExpenditureOrReciept(MoneyModel model)
        {
            model.Id = 1;
            return model;
        }
    }
}

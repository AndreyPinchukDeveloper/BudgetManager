﻿using BudgetManagerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagerLibrary
{
    public interface IDataConnection
    {
        //TODO - code here
        MoneyModel CreateExpenditureOrReciept(MoneyModel model);
    }
}

﻿using BudgetManagerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagerLibrary
{
    public class SqlConnector : IDataConnection
    {
        //TODO - Make here method to save to the database
        /// <summary>
        /// Save a new change to the database
        /// </summary>
        /// <param name="model">The change information</param>
        /// <returns> previos + the unique identifier </returns>
        public MoneyModel CreateExpenditureOrReciept(MoneyModel model)
        {
            model.Id = 1;
            return model;
        }
    }
}

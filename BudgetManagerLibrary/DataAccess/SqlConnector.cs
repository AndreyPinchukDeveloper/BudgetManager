using BudgetManagerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace BudgetManagerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        //TODO - Make here method to save to the database
        /// <summary>
        /// Save a new change to the database
        /// </summary>
        /// <param name="model">The change information</param>
        /// <returns> previos + the unique identifier </returns>
        public MoneyModel CreateChange(MoneyModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("KeyOfDatabase")))
            {
                var p = new DynamicParameters();
                p.Add("@NameOfOperations", model.NameOfChange);
                p.Add("@ValueToChange", model.ValueOfMoney);
                p.Add("@Notes", model.Note);
                p.Add("@Id", 0, dbType:DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("spTableOperations", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@Id");

                return model;
            }
        }
    }
}

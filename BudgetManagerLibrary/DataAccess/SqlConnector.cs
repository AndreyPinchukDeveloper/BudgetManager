using BudgetManagerLibrary.Models;
using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace BudgetManagerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        /// <summary>
        /// Save a new change to the database
        /// </summary>
        public MoneyModel CreateChange(MoneyModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("KeyOfDatabase")))
            {
                var p = new DynamicParameters();
                p.Add("@NameOfOperations", model.NameOfChange);
                p.Add("@ValueToChange", model.ValueOfMoney);
                p.Add("@Notes", model.Note);
                p.Add("@Id", 0, dbType:DbType.Int32, direction: ParameterDirection.Output);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spTable_Operations",p,commandType: CommandType.StoredProcedure);
                model.Id = p.Get<int>("@Id");
                return model;

                connection.Execute("spTableOperations", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@Id");

                return model;
            }
        }
    }
}

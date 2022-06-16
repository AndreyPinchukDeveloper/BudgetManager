﻿using System.Configuration;
using BudgetManagerLibrary.DataAccess;

namespace BudgetManagerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }
        
        public static void InitializeConnections(DatabaseType db)
        {
            switch (db)
            {
                case DatabaseType.Sql:
                    SqlConnector sql = new SqlConnector();
                    Connection = sql;
                    break;
                case DatabaseType.TextFile:
                    TextConnector text = new TextConnector();
                    Connection = text;
                    break;
                default:
                    break;
            }

        }

        public static string ConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        public static void InitializeConnections(bool database, bool textFiles)
        {
            if (database)
            {
                //TODO - create the SQL connection
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }
            if (textFiles)
            {
                //TODO - create the text connection
                TextConnection text = new TextConnection();
                Connections.Add(text);
            }
        }
    }
}

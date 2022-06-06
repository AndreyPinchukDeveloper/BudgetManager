using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows;
using System.Configuration;

namespace FinancialManagerUI.Classes
{
    public static class ManagerDB
    {
        private static SqlConnection sqlConnection = null;
        public static void Connect()
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["KeyOfDatabase"].ConnectionString);
            sqlConnection.Open();
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                MessageBox.Show("good");
            }
        }
    }

}
    
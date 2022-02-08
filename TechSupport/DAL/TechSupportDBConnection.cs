using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupport.DAL
{
    /// <summary>
    /// Sets up the connection for the database 
    /// </summary>
    public static class TechSupportDBConnection
    {
        /// <summary>
        /// Creates a localhost connection to the TechSupport database
        /// </summary>
        /// <returns>The connection to the database</returns>
        public static SqlConnection GetConnection()
        {
            string connectionString =
                "Data Source=localhost;Initial Catalog=TechSupport;" +
                "IntegratedSecurity=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}

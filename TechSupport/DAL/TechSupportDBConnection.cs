
using System.Data.SqlClient;

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
                "Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}

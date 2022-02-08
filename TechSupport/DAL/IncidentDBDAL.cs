using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.model;

namespace TechSupport.DAL
{
    /// <summary>
    /// Retrieves data from the database via MySql Queries
    /// </summary>
    class IncidentDBDAL
    {
        /// <summary>
        /// Retrieves incidents from the database where the DateClosed is null or empty
        /// </summary>
        /// <returns> List of open incidents</returns>
        public List<DBIncident> GetOpenIncidents()
        {
            List<DBIncident> openIncidentList = new List<DBIncident>();

            string selectStatement =
                "SELECT p.ProductCode,  DATE_FORMAT(i.DateOpened, '%m/%d/%y'), c.Name, t.Name, i.title" +
                "FROM Incidents i JOIN Products p ON i.ProductCode = p.ProductCode" +
                "JOIN Technicians t ON i.TechID = t.TechID" +
                "JOIN Customers c ON i.CustomerID = c.CustomerID" +
                "WHERE i.DateClosed IS NULL or i.DateClosed = ''";

            
            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        int productCodeOrd = reader.GetOrdinal("ProductCode");
                        int dateOpenedOrd = reader.GetOrdinal("DateOpened");
                        int customerNameOrd = reader.GetOrdinal("Name");
                        int technicianNameOrd = reader.GetOrdinal("Name");
                        int titleOrd = reader.GetOrdinal("Title");
                        while (reader.Read())
                        {
                            DBIncident incident = new DBIncident();
                            incident.ProductCode = reader.GetString(productCodeOrd);
                            incident.DateOpened = reader.GetDateTime(dateOpenedOrd);
                            incident.Customer = reader.GetString(customerNameOrd);
                            incident.Techniciam = reader.GetString(titleOrd);
                            incident.Title = reader.GetString(titleOrd);
                        }
                    }
                }
            }
            return openIncidentList;
            
        }
        
    }
}

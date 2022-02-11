using System.Collections.Generic;
using System.Data.SqlClient;
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
            SqlConnection connection = TechSupportDBConnection.GetConnection();
            string selectStatement =
                "SELECT Products.ProductCode, FORMAT(Incidents.DateOpened, 'MM-dd-yyyy') as date, Customers.Name, Technicians.Name AS techName, Incidents.title " +
                "FROM Incidents " +
                "JOIN Products ON Incidents.ProductCode = Products.ProductCode " +
                "LEFT JOIN Technicians ON Incidents.TechID = Technicians.TechID " +
                "JOIN Customers ON Incidents.CustomerID = Customers.CustomerID " +
                "WHERE Incidents.DateClosed IS NULL or Incidents.DateClosed = '';";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            SqlDataReader reader= null;
            try
            {
                connection.Open();
                reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    DBIncident incident = new DBIncident();
                    incident.ProductCode = reader["ProductCode"].ToString();
                    incident.DateOpened = reader["date"].ToString();
                    incident.Customer = reader["Name"].ToString();
                    incident.Technician = reader["techName"].ToString();
                    incident.Title = reader["Title"].ToString();
                    openIncidentList.Add(incident);
                }
            }
            finally
            {
                if (connection != null)
                    connection.Close();
                if (reader != null)
                    reader.Close();
            }
            return openIncidentList;
           
        }
        
    }
}

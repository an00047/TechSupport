using System;
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


            using (connection)
            {
                connection.Open();
                using (selectCommand)
                {
                    using (reader = selectCommand.ExecuteReader())
                    {
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
                }
            }

            return openIncidentList;
           
        }


        public void AddIncident(DBIncident incident)
        {
            SqlConnection connection = TechSupportDBConnection.GetConnection();
            string insertStatement =
                @"INSERT Incidents (CustomerID, ProductCode, DateOpened, Title, Description) 
                    VALUES (@CustomerID, @ProductCode, @DateOpened, @Title, @Description)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            if (incident.CustomerID <= 0)
            {
                insertCommand.Parameters.AddWithValue("@CustomerID", DBNull.Value);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@CustomerID", incident.CustomerID);
            }

            if (string.IsNullOrEmpty(incident.ProductCode))
            {
                insertCommand.Parameters.AddWithValue("@ProductCode", DBNull.Value);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@ProductCode", incident.ProductCode);
            }

            insertCommand.Parameters.AddWithValue("@DateOpened", DateTime.Now);

            if (string.IsNullOrEmpty(incident.Title))
            {
                insertCommand.Parameters.AddWithValue("@Title", DBNull.Value);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@Title", incident.Title);
            }

            if (string.IsNullOrEmpty(incident.Description))
            {
                insertCommand.Parameters.AddWithValue("@Description", DBNull.Value);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@Description", incident.Description);
            }            

            using (connection)
            {
                connection.Open();
                using (insertCommand)
                {
                    insertCommand.ExecuteNonQuery();                    
                }
            }
        }

        public DBIncident GetIncidentByID(int incidentID)
        {
            DBIncident incident = new DBIncident();
            SqlConnection connection = TechSupportDBConnection.GetConnection();
            string selectStatement =
                @"SELECT Products.ProductCode, FORMAT(Incidents.DateOpened, 'MM-dd-yyyy') as date, 
                   Customers.Name, Incidents.Title, Incidents.Description, Technicians.TechID
                FROM Incidents 
                JOIN Products ON Incidents.ProductCode = Products.ProductCode 
                JOIN Customers ON Incidents.CustomerID = Customers.CustomerID 
                WHERE Incidents.IncidentID = @IncidentID";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@IncidentID", incidentID);
            SqlDataReader reader = null;
            using (connection)
            {
                connection.Open();
                using (selectCommand)
                {
                    using (reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            incident.ProductCode = reader["ProductCode"].ToString();
                            incident.Technician = reader["TechID"].ToString();
                            incident.DateOpened = reader["date"].ToString();
                            incident.Customer = reader["Name"].ToString();
                            incident.Title = reader["Title"].ToString();
                            incident.Description = reader["Description"].ToString();
                        }
                    }
                }
            }
            return incident;
        }

    }
}

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

        /// <summary>
        /// Adds the incident.
        /// </summary>
        /// <param name="incident">The incident.</param>
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

        /// <summary>
        /// Gets the incident by identifier.
        /// </summary>
        /// <param name="incidentID">The incident identifier.</param>
        /// <returns></returns>
        public DBIncident GetIncidentByID(int incidentID)
        {
            DBIncident incident = new DBIncident();
            SqlConnection connection = TechSupportDBConnection.GetConnection();
            string selectStatement =
                @"SELECT Products.ProductCode, FORMAT(Incidents.DateOpened, 'MM-dd-yyyy') as date, 
                   Customers.Name, Incidents.Title, Incidents.Description, Incidents.TechID, 
                   Incidents.DateClosed
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

                            try
                            {
                                DBNull dateClosed = (DBNull)reader["DateClosed"];
                                incident.DateClosed = null;
                            }
                            catch
                            {
                                incident.DateClosed = (DateTime?)reader["DateClosed"];
                            }

                            try
                            {
                                DBNull techID = (DBNull)reader["TechID"];
                                incident.TechID = null;
                            }
                            catch
                            {
                                incident.TechID = (int?)reader["TechID"];
                            }

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

        /// <summary>
        /// Updates the incident.
        /// </summary>
        /// <param name="incidentID">The incident identifier.</param>
        /// <param name="description">The description.</param>
        /// <param name="techID">The tech identifier.</param>
        public void UpdateIncident(int incidentID, DateTime? oldDateClosed, string oldDescription, int? oldTechID, DateTime? newDateClosed, string newDescription, int? newTechID)
        {
            SqlConnection connection = TechSupportDBConnection.GetConnection();
            string updateStatement =
                @"UPDATE Incidents SET Description = @newDescription, TechID = @newTechID
                    WHERE IncidentID = @incidentID AND Description = @oldDescription
                    AND (TechID = @oldTechID OR TechID IS NULL AND @oldTechID IS NULL)
                    AND (DateClosed = @oldDateClosed OR DateClosed IS NULL AND @oldDateClosed IS NULL)";
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@incidentID", incidentID);

            if (oldTechID.HasValue)
                updateCommand.Parameters.AddWithValue("@oldTechID", oldTechID);
            else
                updateCommand.Parameters.AddWithValue("@oldTechId", DBNull.Value);

            if (oldDescription != "")
                updateCommand.Parameters.AddWithValue("@oldDescription", oldDescription);
            else
                updateCommand.Parameters.AddWithValue("@oldDescription", DBNull.Value);

            if (oldDateClosed != null)
                updateCommand.Parameters.AddWithValue("@oldDateClosed", oldDateClosed);
            else
                updateCommand.Parameters.AddWithValue("@oldDateClosed", DBNull.Value);

            if (newTechID.HasValue)
                updateCommand.Parameters.AddWithValue("@newTechID", newTechID);
            else
                updateCommand.Parameters.AddWithValue("@newTechId", DBNull.Value);

            if (newDescription != "")
                updateCommand.Parameters.AddWithValue("@newDescription", newDescription);
            else
                updateCommand.Parameters.AddWithValue("@newDescription", DBNull.Value);

            if (newDateClosed != null) 
                updateCommand.Parameters.AddWithValue("@newDateClosed", newDateClosed);
            else
                updateCommand.Parameters.AddWithValue("@newDateClosed", DBNull.Value);


            using (connection)
            {
                connection.Open();
                using (updateCommand)
                {
                    updateCommand.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Gets the open incidents by technician.
        /// </summary>
        /// <param name="techID">The tech identifier.</param>
        /// <returns>The list of incidents</returns>
        public List<DBIncident> GetOpenIncidentsByTechnician(int techID)
        {
            List<DBIncident> openIncidentList = new List<DBIncident>();
            SqlConnection connection = TechSupportDBConnection.GetConnection();
            string selectStatement =
                @"  SELECT Products.Name AS productName, FORMAT(Incidents.DateOpened, 'MM-dd-yyyy') as date, Customers.Name, Incidents.title
                  FROM Incidents 
                  JOIN Products ON Incidents.ProductCode = Products.ProductCode
                  JOIN Technicians ON Incidents.TechID = Technicians.TechID
                  JOIN Customers ON Incidents.CustomerID = Customers.CustomerID
                  WHERE (Incidents.DateClosed IS NULL or Incidents.DateClosed = '')
                  AND (Incidents.techID = @techID)";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@techID", techID);
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
                            DBIncident incident = new DBIncident();
                            incident.ProductName = reader["productName"].ToString();
                            incident.DateOpened = reader["date"].ToString();
                            incident.Customer = reader["Name"].ToString();
                            incident.Title = reader["Title"].ToString();
                            openIncidentList.Add(incident);
                        }
                    }
                }
            }

            return openIncidentList;
        }

    }
}

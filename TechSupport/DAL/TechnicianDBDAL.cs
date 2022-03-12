using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.model;

namespace TechSupport.DAL
{
    class TechnicianDBDAL
    {
        /// <summary>
        /// Gets the technicians.
        /// </summary>
        /// <returns></returns>
        public List<DBTechnician> GetTechnicians()
        {
            List<DBTechnician> technicianList = new List<DBTechnician>();
            SqlConnection connection = TechSupportDBConnection.GetConnection();
            string selectStatement =
                @"SELECT TechID, Name FROM Technicians;";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
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
                            DBTechnician technician = new DBTechnician();
                            technician.TechID = Convert.ToInt32(reader["TechID"]);
                            technician.Name = reader["Name"].ToString();
                            technicianList.Add(technician);
                        }
                    }
                }
            }

            return technicianList;
        }

        public List<DBTechnician> GetAllTechniciansWithIncidents()
        {
            List<DBTechnician> technicianList = new List<DBTechnician>();
            SqlConnection connection = TechSupportDBConnection.GetConnection();
            string selectStatement =
                @"SELECT DISTINCT Technicians.* 
                FROM Technicians 
                JOIN Incidents ON Technicians.TechID = Incidents.TechID;";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
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
                            DBTechnician technician = new DBTechnician();
                            technician.TechID = Convert.ToInt32(reader["TechID"]);
                            technician.Name = reader["Name"].ToString();
                            technician.Email = reader["Email"].ToString();
                            technician.Phone = reader["Phone"].ToString();
                            technicianList.Add(technician);
                        }
                    }
                }
            }

            return technicianList;
        }
    }
}

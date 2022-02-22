using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.model;

namespace TechSupport.DAL
{
    class TechnicianDBDAL
    {
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
    }
}

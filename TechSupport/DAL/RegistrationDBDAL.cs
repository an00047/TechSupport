using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.model;

namespace TechSupport.DAL
{
    class RegistrationDBDAL
    {
        /// <summary>
        /// Determines whether the specified customer identifier is registered.
        /// </summary>
        /// <param name="customerID">The customer identifier.</param>
        /// <param name="productCode">The product code.</param>
        /// <returns>
        ///   <c>true</c> if the specified customer identifier is registered; otherwise, <c>false</c>.
        /// </returns>
        public bool IsRegistered(int customerID, string productCode)
        {
            List<DBRegistration> registrationList = new List<DBRegistration>();
            SqlConnection connection = TechSupportDBConnection.GetConnection();
            string selectStatement =
                @"SELECT * FROM Registrations where CustomerID = @customerID AND ProductCode = @productCode;";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@customerID", customerID);
            selectCommand.Parameters.AddWithValue("@productCode", productCode);
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
                            DBRegistration registration = new DBRegistration();
                            registration.CustomerID = Convert.ToInt32(reader["CustomerID"]);
                            registration.ProductCode = reader["ProductCode"].ToString();
                            registrationList.Add(registration);
                        }
                    }
                }
            }
            return registrationList.Count > 0; 
        }
    }
}

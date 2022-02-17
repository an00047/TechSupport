using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.model;

namespace TechSupport.DAL
{
    class CustomerDBDAL
    {
        public List<DBCustomer> GetCustomers()
        {
            List<DBCustomer> customerList = new List<DBCustomer>();
            SqlConnection connection = TechSupportDBConnection.GetConnection();
            string selectStatement =
                @"SELECT CustomerID, Name FROM Customers;";

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
                            DBCustomer customer = new DBCustomer();
                            customer.CustomerID = Convert.ToInt32(reader["CustomerID"]);
                            customer.Name = reader["Name"].ToString();
                            customerList.Add(customer);
                        }
                    }
                }
            }

            return customerList;
        }
    }
}

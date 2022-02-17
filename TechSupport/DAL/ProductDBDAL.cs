using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.model;

namespace TechSupport.DAL
{
    class ProductDBDAL
    {
        public List<DBProduct> GetProducts()
        {
            List<DBProduct> productList = new List<DBProduct>();
            SqlConnection connection = TechSupportDBConnection.GetConnection();
            string selectStatement =
                @"SELECT ProductCode, Name FROM Products;";

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
                            DBProduct product = new DBProduct();
                            product.ProductCode = reader["ProductCode"].ToString();
                            product.Name = reader["Name"].ToString();
                            productList.Add(product);
                        }
                    }
                }
            }

            return productList;
        }
    }
}

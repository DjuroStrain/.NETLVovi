using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class OrderRepository
    {
        String sSqlConnectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString.ToString();

        public List<OrdersClass> GetOrders()
        {
            List<OrdersClass> Orders = new List<OrdersClass>();
            using (DbConnection connection = new SqlConnection(sSqlConnectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Orders";
                connection.Open();

                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Orders.Add(new OrdersClass()
                        {
                            OrderId = (int)reader["Id"],
                            OrderDate = Convert.ToDateTime(reader["OrderDate"]),
                            OrderNumber = (string)reader["OrderNumber"],
                            CustomerID = (int)reader["CustomerId"],
                            TotalAmount = (decimal)reader["TotalAmount"]

                        });
                    }
                }
            }
            return Orders;
        }
    }
}

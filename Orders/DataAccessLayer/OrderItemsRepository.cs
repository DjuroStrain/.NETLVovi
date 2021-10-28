using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class OrderItemsRepository
    {
        String sSqlConnectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString.ToString();

        public List<OrderItems> GetOrderItems()
        {
            List<OrderItems> OrderItems = new List<OrderItems>();
            using (DbConnection connection = new SqlConnection(sSqlConnectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FRoM OrderItem";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        OrderItems.Add(new OrderItems()
                        {
                            OrderItemId = (int)reader["Id"],
                            OrderId = (int)reader["orderId"],
                            ProductId2 = (int)reader["ProductlId"],
                            OrderItemsUnitPrice = (decimal)reader["UnitPrice"],
                            Quantity = (int)reader["Quantity"]
                        });
                    }
                }
            }
            return OrderItems;
        }
    }
}

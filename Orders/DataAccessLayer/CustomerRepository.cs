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
    public class CustomerRepository
    {
        String sSqlConnectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString.ToString();

        public List<Costumers> GetAll()
        {
            List<Costumers> Costumers = new List<Costumers>();
            using (DbConnection connection = new SqlConnection(sSqlConnectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Customer";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Costumers.Add(new Costumers()
                        {
                            CustomerId = (int)reader["Id"],
                            FirstName = (string)reader["FirstName"],
                            LastName = (string)reader["LastName"],
                            City = (string)reader["City"],
                            Country = (string)reader["Country"],
                            Phone = (string)reader["Phone"]
                        });
                    }
                }
            }
            return Costumers;
        }
    }
}

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
    public class SuppliereRepository
    {
        String sSqlConnectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString.ToString();

        public List<Suppliers> GetAll()
        {
            List<Suppliers> Suppliers = new List<Suppliers>();
            using (DbConnection connection = new SqlConnection(sSqlConnectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Supplier";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Suppliers.Add(new Suppliers()
                        {
                            SupplierId = (int)reader["Id"],
                            CompanyName = (string)reader["CompanyName"],
                            ContactName = (string)reader["ContactName"],
                            ContactTitle = (string)reader["ContactTitle"],
                            City = (string)reader["City"],
                            Country = (string)reader["Country"],
                            Phone = (string)reader["Phone"],
                            Fax = (string)reader["Fax"]
                        });
                    }
                }
            }
            return Suppliers;
        }
    }
}

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
        public class ProductRepository
        {
            String sSqlConnectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString.ToString();
            private SuppliereRepository suppliereRepository = new SuppliereRepository();
            public List<Products> GetAll()
            {
                List<Products> Products = new List<Products>();
            var suppliers = suppliereRepository.GetAll();
                using (DbConnection connection = new SqlConnection(sSqlConnectionString))
                using (DbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Product";
                    connection.Open();
                    using (DbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Products.Add(new Products()
                            {
                                ProductId = (int)reader["Id"],
                                ProductName = (string)reader["ProductName"],
                                SupplierId = (int)reader["SupplierId"],
                                UnitPrice = (decimal)reader["UnitPrice"],
                                Package = (string)reader["Package"],
                                isDiscounted = (bool)reader["isDiscounted"]
                            });
                        } 
                    }
                }
                return Products;
            }
        }
    }


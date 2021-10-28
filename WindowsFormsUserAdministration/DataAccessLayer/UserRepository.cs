using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data.SqlClient;
using System.Data.Common;
using System.Configuration;

namespace DataAccessLayer
{
    public class UserRepository
    {
        String sSqlConnectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString.ToString();

        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            using (DbConnection connection = new SqlConnection(sSqlConnectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Users";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        users.Add(new User()
                        {
                            UserID = (int)reader["UserId"],
                            UserName = (string)reader["UserName"],
                            UserPassword = (string)reader["UserPassword"],
                            UserFirstName = (string)reader["UserFirstName"],
                            UserLastName = (string)reader["UserLastName"]
                        });
                    }
                }
            }
            return users;
        }

        public void UpdateUsers(User oUser)
        {
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "UPDATE Users SET UserFirstName='"+ oUser.UserFirstName+"',UserLastName='"+oUser.UserLastName+"',UserPassword='"+oUser.UserPassword+"'WHERE UserId="+oUser.UserID; 
                oConnection.Open();

                using (DbDataReader oReader = oCommand.ExecuteReader())
                {
                }

                oConnection.Close();
            }
        }

        public void DeleteUsers(User oUser)
        {
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "DELETE FROM Users WHERE UserId =" + oUser.UserID;
                oConnection.Open();

                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
                oConnection.Close();
            }
        }

        public void AddUsers(User oUser)
        {
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "INSERT INTO Users (UserName, UserPassword, UserFirstName, UserLastName)" + "VALUES ('"+oUser.UserName+"','"+oUser.UserPassword+"','"+oUser.UserFirstName+"','"+ oUser.UserLastName+"')";
                oConnection.Open();

                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
                oConnection.Close();
            }
        }
    }
}

    


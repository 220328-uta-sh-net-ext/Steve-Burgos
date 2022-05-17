using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using Models;
using Connections;
namespace DL
{
    public class DLUser
    {

        static public IEnumerable<UserModel> SearchUsers()
        {

            string commandString = $"SELECT* FROM [Users]";

            using SqlConnection connection = new(ConnectionSQL.connectionString);
            connection.Open();
            using SqlCommand command = new(commandString, connection);
            //Console.WriteLine(command);
            using SqlDataReader reader = command.ExecuteReader();

            var users = new List<UserModel>();


            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    users.Add(new UserModel
                    {
                        ID = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        LastName = reader.GetString(2),
                        Email = reader.GetString(3),
                        Phone = reader.GetString(4),
                        Password = reader.GetString(5),

                    });

                }
            }
            return users;
        }

    }
}
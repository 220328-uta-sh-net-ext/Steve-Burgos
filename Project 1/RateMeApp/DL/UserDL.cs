using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using Models;



namespace DL
{
    public class UserDL
    {
        static public List<User> SearchUsers(string connectionString, string tableName)
        {

            string commandString = $"SELECT* FROM [{tableName}]";

            using SqlConnection connection = new(connectionString);
            connection.Open();
            using SqlCommand command = new(commandString, connection);
            //Console.WriteLine(command);
            using SqlDataReader reader = command.ExecuteReader();




            // List<Object> myTable;
            // Create an empty datatable for users
            //DataTable UserTable = new DataTable("Users");
            var users = new List<User>();
            // Provide the schema for UserTable
            //UserTable.Columns.Add("ID", Type.GetType("System.Int32"));
            //UserTable.Columns.Add("First_Name", Type.GetType("System.String"));
           // UserTable.Columns.Add("Last Name", Type.GetType("System.String"));
           // UserTable.Columns.Add("Email", Type.GetType("System.String"));
           // UserTable.Columns.Add("Phone", Type.GetType("System.String"));
           // UserTable.Columns.Add("Password", Type.GetType("System.String"));
           // UserTable.Columns.Add("Admin", Type.GetType("System.Bool"));


            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    users.Add(new User
                    {
                        ID = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        LastName = reader.GetString(2),
                        Email = reader.GetString(3),
                        Phone = reader.GetString(4),
                        Password = reader.GetString(5),
                        UserType = reader.GetBoolean(6),
                    });
                }
            }
            //myTable.ForEach(x => Console.WriteLine(x));

            //Console.WriteLine(commandString);
             return users;
        }
    }
}

global using Serilog;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.ComponentModel;
using DL;
using Models;
using RateMeApp;
using System.Data.SqlClient;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IConfiguration _configuration;
    public UserController(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    [HttpGet]
    public IEnumerable<User> Get()
    {
        var users = GetUsers();
        return users;
    }
    private IEnumerable<User> GetUsers()
    {
        var users = new List<User>();
        using (var connection = new SqlConnection(_configuration.GetConnectionString("RestaurantDatabase")))
        {
            var sql = "SELECT* FROM Users";
            connection.Open();
            using SqlCommand command = new SqlCommand(sql, connection);
            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                var user = new User()
                {
                    ID = (int)reader["Id"],
                    FirstName = reader["first name"].ToString(),
                    LastName = reader["last name"].ToString(),
                    Email = reader["email"].ToString(),
                    Phone = reader["phone"].ToString(),
                    Password = reader["password"].ToString()
                };

                users.Add(user);
            }


        }
        return users;
    }
}


[Route("api/[controller]")]
[ApiController]

public class AddUserController : ControllerBase
{
    private readonly IConfiguration _configuration;
    public AddUserController(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    [HttpPost]
    public IEnumerable<User> Get(string firstName, string lastName, string email, string phone, string password)
    {
        var users = GetUsers(firstName, lastName, email, phone, password);
        return users;
    }
    private IEnumerable<User> GetUsers(string firstName, string lastName, string email, string phone, string password)
    {
        var users = new List<User>();
        using (var connection = new SqlConnection(_configuration.GetConnectionString("RestaurantDatabase")))
        {
            var sql = $"Insert into users ([first name], [last name], [email], [phone], [password], [admin]) Values ('{firstName}', '{lastName}', '{email}', '{phone}', '{password}', 1)";
            connection.Open();
            using SqlCommand command = new SqlCommand(sql, connection);
            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                var user = new User()
                {
                    ID = (int)reader["Id"],
                    FirstName = reader["first name"].ToString(),
                    LastName = reader["last name"].ToString(),
                    Email = reader["email"].ToString(),
                    Phone = reader["phone"].ToString(),
                    Password = reader["password"].ToString()
                };

                users.Add(user);
            }


        }
        return users;
    }
}
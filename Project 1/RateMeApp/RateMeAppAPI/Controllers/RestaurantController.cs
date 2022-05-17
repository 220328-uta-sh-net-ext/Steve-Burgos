global using Serilog;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.ComponentModel;
using DL;
using Models;
using RateMeApp;
using System.Data.SqlClient;
namespace RateMeAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {


        private readonly IConfiguration _configuration;
        public RestaurantController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet]
        public IEnumerable<Restaurant> Get()
        {
            var restaurants = GetRestaurants();
            return restaurants;
        }
        private IEnumerable<Restaurant> GetRestaurants()
        {
            var restaurants = new List<Restaurant>();
            using (var connection = new SqlConnection(_configuration.GetConnectionString("RestaurantDatabase")))
            {
                var sql = "SELECT* FROM Restaurants";
                connection.Open();
                using SqlCommand command = new SqlCommand(sql, connection);
                using SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var restaurant = new Restaurant()
                    {
                        ID = (int)reader["Id"],
                        Name = reader["Name"].ToString(),
                        Address = reader["Address"].ToString(),
                        City = reader["City"].ToString(),
                        State = reader["state"].ToString(),
                        ZipCode = reader["zip"].ToString(),
                        Country = reader["Country"].ToString(),
                        Phone = reader["Phone"].ToString(),
                        Email = reader["Email"].ToString(),
                        Website = reader["Website"].ToString()

                    };

                    restaurants.Add(restaurant);
                }

            }
            return restaurants;
        }




    }



    [Route("api/[controller]")]
    [ApiController]

    public class RestaurantSearchController : ControllerBase
    {


        private readonly IConfiguration _configuration;
        public RestaurantSearchController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public IEnumerable<Restaurant> Get(string restaurantName)
        {
            var restaurants = SearchRestaurants(restaurantName);
            return restaurants;
        }
        private IEnumerable<Restaurant> SearchRestaurants(string restaurantName)
        {
            var restaurants = new List<Restaurant>();
            using (var connection = new SqlConnection(_configuration.GetConnectionString("RestaurantDatabase")))
            {
                var sql = $"SELECT* FROM Restaurants Where Name like '{restaurantName}%'";
                connection.Open();
                using SqlCommand command = new SqlCommand(sql, connection);
                using SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var restaurant = new Restaurant()
                    {
                        ID = (int)reader["Id"],
                        Name = reader["Name"].ToString(),
                        Address = reader["Address"].ToString(),
                        City = reader["City"].ToString(),
                        State = reader["state"].ToString(),
                        ZipCode = reader["zip"].ToString(),
                        Country = reader["Country"].ToString(),
                        Phone = reader["Phone"].ToString(),
                        Email = reader["Email"].ToString(),
                        Website = reader["Website"].ToString()

                    };

                    restaurants.Add(restaurant);
                }

            }
            return restaurants;

        }
    }
}


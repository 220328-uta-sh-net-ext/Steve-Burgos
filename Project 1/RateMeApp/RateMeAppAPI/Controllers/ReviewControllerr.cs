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
    public class ReviewControllerr : Controller
    {

        private readonly IConfiguration _configuration;
        public ReviewControllerr(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet]
        public IEnumerable<Review> Get()
        {
            var reviews = GetReviews();
            return reviews;
        }
        private IEnumerable<Review> GetReviews()
        {
            var Reviews = new List<Review>();
            using (var connection = new SqlConnection(_configuration.GetConnectionString("RestaurantDatabase")))
            {
                var sql = "SELECT* FROM Reviews";
                connection.Open();
                using SqlCommand command = new SqlCommand(sql, connection);
                using SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var review = new Review()
                    {
                        ID = (int)reader["Id"],
                        RestaurantID = (int)reader["Restaurant"],
                        Score = (int)reader["Score"],
                        WrittenReview = reader["Review"].ToString()
                    };

                    Reviews.Add(review);
                }

            }
            return Reviews;
        }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsFromRestaurant : Controller
    {

        private readonly IConfiguration _configuration;
        public ReviewsFromRestaurant(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet]
        public IEnumerable<Review> Get(string restaurantName)
        {
            var reviews = GetReviews(restaurantName);
            return reviews;
        }
        private IEnumerable<Review> GetReviews(string restaurantName)
        {
            var Reviews = new List<Review>();
            using (var connection = new SqlConnection(_configuration.GetConnectionString("RestaurantDatabase")))

            {
                var sql = $"SELECT score, review FROM [Reviews] WHERE[Name] LIKE '%[0-9]%'";
                connection.Open();
                using SqlCommand command = new SqlCommand(sql, connection);
                using SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var review = new Review()
                    {
                        ID = (int)reader["Id"],
                        RestaurantID = (int)reader["Restaurant"],
                        Score = (int)reader["Score"],
                        WrittenReview = reader["Review"].ToString()
                    };

                    Reviews.Add(review);
                }

            }
            return Reviews;
        }
    }



    [Route("api/[controller]")]
    [ApiController]
    public class AddReview : Controller
    {



        private readonly IConfiguration _configuration;
        public AddReview(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet]
        public IEnumerable<Review> Get(string restaurantName, int score, string writtenReview)
        {
            var reviews = GetReviews(restaurantName, score, writtenReview);
            return reviews;
        }
        private IEnumerable<Review> GetReviews(string restaurantName, int score, string writtenReview)

        {
            int myID = (int)SQLDataLogic.getRestaurantID(_configuration.GetConnectionString("RestaurantDatabase"), restaurantName);
            var Reviews = new List<Review>();
            using (var connection = new SqlConnection(_configuration.GetConnectionString("RestaurantDatabase")))

            {
                var sql = $"Insert Into Reviews (restaurant, score, review) values({myID},{score},'{writtenReview}')";
                connection.Open();
                using SqlCommand command = new SqlCommand(sql, connection);
                using SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var review = new Review()
                    {
                        ID = (int)reader["Id"],
                        RestaurantID = (int)reader["Restaurant"],
                        Score = (int)reader["Score"],
                        WrittenReview = reader["Review"].ToString()
                    };

                    Reviews.Add(review);
                }

            }
            return Reviews;
        }
    }





    [Route("api/[controller]")]
    [ApiController]
    public class ViewReviewsOfRestaurant
    {

        private readonly IConfiguration _configuration;
        public ViewReviewsOfRestaurant(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet]
        public IEnumerable<Review> Get(string restaurantName)
        {
            var reviews = GetReviews(restaurantName);
            return reviews;
        }
        private IEnumerable<Review> GetReviews(string restaurantName)

        {
            int myID = (int)SQLDataLogic.getRestaurantID(_configuration.GetConnectionString("RestaurantDatabase"), restaurantName);
            var Reviews = new List<Review>();
            using (var connection = new SqlConnection(_configuration.GetConnectionString("RestaurantDatabase")))

            {
                var sql = $"SELECT score, review FROM [Reviews] WHERE [Restaurant] LIKE {myID.ToString()}";
                connection.Open();
                using SqlCommand command = new SqlCommand(sql, connection);
                using SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var review = new Review()
                    {
                        
                        Score = (int)reader["Score"],
                        WrittenReview = reader["Review"].ToString()
                    };

                    Reviews.Add(review);
                }

            }
            return Reviews;
        }
    }
}

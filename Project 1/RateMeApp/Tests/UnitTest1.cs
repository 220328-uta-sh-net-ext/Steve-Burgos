using Xunit;
using Models;
using DL;

namespace Tests
{
    public class UnitTest
    {
        [Fact]
        public void FirstNameShouldBevalidData()
        {
            //Arrange
            User userModel = new User();
            string valid = "abc";
            //Act
            userModel.FirstName = valid;
            //Assert
            Assert.NotNull(userModel.FirstName);
            Assert.Equal(valid, userModel.FirstName);
        }

        [Fact]
        public void LastNameShouldBevalidData()
        {
            //Arrange
            User userModel = new User();
            string valid = "abc";
            //Act
            userModel.LastName = valid;
            //Assert
            Assert.NotNull(userModel.LastName);
            Assert.Equal(valid, userModel.LastName);
        }


        [Fact]
        public void EmailValid()
        {
            //Arrange
            User userModel = new User();
            string valid = "abc@gmail.com";
            //Act
            userModel.Email = valid;
            //Assert
            Assert.NotNull(userModel.Email);
            Assert.Equal(valid, userModel.Email);
        }
        [Fact]
        public void PhoneValid()
        {
            //Arrange
            User userModel = new User();
            string valid = "9999999999";
            //Act
            userModel.Phone = valid;
            //Assert
            Assert.NotNull(userModel.Phone);
            Assert.Equal(valid, userModel.Phone);
        }

        [Fact]
        public void UserID()
        {
            //Arrange
            User userModel = new User();
            int valid = 3;
            //Act
            userModel.ID = valid;
            //Assert
            Assert.NotNull(userModel.ID);
            Assert.Equal(valid, userModel.ID);
        }

        [Fact]
        public void PasswordCheck()
        {
            //Arrange
            User userModel = new User();
            string valid = "password";
            //Act
            userModel.Password = valid;
            //Assert
            Assert.NotNull(userModel.Password);
            Assert.Equal(valid, userModel.Password);
        }
        [Fact]
        public void UserTypeCheck()
        {
            //Arrange
            User userModel = new User();
            bool valid = false;
            //Act
            userModel.UserType = valid;
            //Assert
            Assert.NotNull(userModel.UserType);
            Assert.Equal(valid, userModel.UserType);
        }

        [Fact]
        public void ValidRestaurantName()
        {
            //Arrange
            Restaurant model = new Restaurant();
            string valid = "The Restaurant Model is Valid";
            //Act
            model.Name = valid;
            //Assert
            Assert.NotNull(model.Name);
            Assert.Equal(valid, model.Name);
        }
        [Fact]
        public void ValidRestaurantAddress()
        {
            //Arrange
            Restaurant model = new Restaurant();
            string valid = "9999 Address";
            model.Address = valid;
            //Assert
            Assert.NotNull(model.Address);
            Assert.Equal(valid, model.Address);
        }

        [Fact]
        public void ValidRestaurantCity()
        {
            //Arrange
            Restaurant model = new Restaurant();
            string valid = "thecity";
            model.City = valid;
            //Assert
            Assert.NotNull(model.City);
            Assert.Equal(valid, model.City);
        }

        [Fact]
        public void ValidRestaurantState()
        {
            //Arrange
            Restaurant model = new Restaurant();
            string valid = "TX";
            model.State = valid;
            //Assert
            Assert.NotNull(model.State);
            Assert.Equal(valid, model.State);
        }

        [Fact]
        public void ValidRestaurantZip()
        {
            //Arrange
            Restaurant model = new Restaurant();
            string valid = "75150";
            model.ZipCode = valid;
            //Assert
            Assert.NotNull(model.ZipCode);
            Assert.Equal(valid, model.ZipCode);
        }
        [Fact]
        public void ValidRestaurantCountry()
        {
            //Arrange
            Restaurant model = new Restaurant();
            string valid = "USA";
            model.Country = valid;
            //Assert
            Assert.NotNull(model.Country);
            Assert.Equal(valid, model.Country);
        }

        [Fact]
        public void ValidRestaurantWebsite()
        {
            //Arrange
            Restaurant model = new Restaurant();
            string valid = "www.google.com";
            model.Website = valid;
            //Assert
            Assert.NotNull(model.Website);
            Assert.Equal(valid, model.Website);
        }

        [Fact]
        public void ValidRestaurantPhone()
        {
            //Arrange
            Restaurant model = new Restaurant();
            string valid = "9999999999";
            model.Phone = valid;
            //Assert
            Assert.NotNull(model.Phone);
            Assert.Equal(valid, model.Phone);
        }

    }
}
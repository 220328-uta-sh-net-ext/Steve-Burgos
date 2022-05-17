using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;

namespace UI
{
    public class SearchRestaurant: UIMenus
    {

        public void Display()
        {
            const string connectionStringFilePath = "../connections.txt";
            string connectionString = File.ReadAllText(connectionStringFilePath);

            Console.WriteLine("Enter <exit> to exit");
            Console.WriteLine("Enter <0> to search restaurant by rating");
            Console.WriteLine("Enter <1> to search restaurant by name");
            Console.WriteLine("Enter <2> to search restaurant by address");
            Console.WriteLine("Enter <3> to search restaurant by city");
            Console.WriteLine("Enter <4> to search restaurant by state");
            Console.WriteLine("Enter <5> to search restaurant by zip");
            Console.WriteLine("Enter <6> to search restaurant by country");

            Console.Write("Input: ");
            string input = Console.ReadLine();

            while(input != "exit" && input != "0" && input != "1" && input != "2" && input != "3" && input != "4" && input != "5" && input != "6")
            {
                Console.Clear();
                Console.WriteLine("Enter <exit> to exit");
                Console.WriteLine("Enter <0> to search restaurant by rating");
                Console.WriteLine("Enter <1> to search restaurant by name");
                Console.WriteLine("Enter <2> to search restaurant by address");
                Console.WriteLine("Enter <3> to search restaurant by city");
                Console.WriteLine("Enter <4> to search restaurant by state");
                Console.WriteLine("Enter <5> to search restaurant by zip");
                Console.WriteLine("Enter <6> to search restaurant by country");
                Console.Write("Input: ");
                input = Console.ReadLine();
            }

            switch (input) {

                case "exit":
                    break;
                case "0":
                    Console.Clear();
                    Console.Write("Type in Rating you are looking for: ");
                    string rating = Console.ReadLine();
                    while (rating != "1" && rating != "2" && rating != "3" && rating != "4" && rating != "5")
                    {
                        Console.Clear();
                        Console.Write("Type in Rating you are looking for between 1-5: ");
                        rating = Console.ReadLine();
                    }
                    SQLDataLogic.getRestaurantAverageRating(connectionString, rating);
                    Console.ReadLine();
                    break;
                case "1":
                    Console.Clear();
                    Console.Write("Type in the name you are looking for: ");
                    string name = Console.ReadLine();
                    SQLDataLogic.SearchTable(connectionString, "restaurants", "name", name);
                    //string connectionString, string tableName, string columnName, string searchItem)
                    //string commandString = $"SELECT* FROM [{tableName}] WHERE [{columnName}] LIKE '{searchItem}%'";
                    Console.ReadLine();
                    break;
                case "2":
                    Console.Clear();
                    Console.Write("Type in the address you are looking for: ");
                    string address = Console.ReadLine();
                    SQLDataLogic.SearchTable(connectionString, "restaurants", "address", address);
                    Console.ReadLine();
                    break;
                case "3":
                    Console.Clear();
                    Console.Write("Type in the city you are looking for: ");
                    string city = Console.ReadLine();
                    SQLDataLogic.SearchTable(connectionString, "restaurants", "city", city);
                    Console.ReadLine();
                    break;
                case "4":
                    Console.Clear();
                    Console.Write("Type in the state you are looking for: ");
                    string state = Console.ReadLine();
                    SQLDataLogic.SearchTable(connectionString, "restaurants", "state", state);
                    Console.ReadLine();
                    break;
                case "5":
                    Console.Clear();
                    Console.Write("Type in the zip you are looking for: ");
                    string zip = Console.ReadLine();
                    SQLDataLogic.SearchTable(connectionString, "restaurants", "zip", zip);
                    Console.ReadLine();
                    break;
                case "6":
                    Console.Clear();
                    Console.Write("Type in the country you are looking for: ");
                    string country = Console.ReadLine();
                    SQLDataLogic.SearchTable(connectionString, "restaurants", "country", country);
                    Console.ReadLine();
                    break;
                default:
                    Console.ReadLine();
                    break;
            }
                
            }


        public string UserChoice()
        {
            Console.Clear();
            return "UserView";
        }
    }
}

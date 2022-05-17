using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;


namespace UI
{

        public class UserMenu : UIMenus
        {
            public void Display()
            {
                

                Console.WriteLine("Enter <logout> to logout ");

                Console.WriteLine("Enter <0> to add a review to a restaurant ");

                Console.WriteLine("Enter <1> to view all restaurants");

                Console.WriteLine("Enter <2> to search for a restaurant");
               
                Console.WriteLine("Enter <3> to search reviews of restaurants");

                
                Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||");

        }

            public string UserChoice()
            {
            const string connectionStringFilePath = "../connections.txt";
            string connectionString = File.ReadAllText(connectionStringFilePath);

            // Console.ReadLine returns null if redirecting from a file and the file ends
            if (Console.ReadLine() is not string userInput)
                    throw new InvalidDataException("end of input");

                switch (userInput)
                {
                    case "0":
                        Console.Clear();
                        return "AddReview";
                    case "1":
                        Console.Clear();
                        SQLDataLogic.GetTable(connectionString, "Restaurants");
                    
                        Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||");

                        return "UserView";
                    case "2":
                        Console.Clear();
                        return "SearchRestaurant";
                    case "3":
                        Console.Clear();
                        return "SearchReviews";
                    case "logout":
                            Console.Clear();
                            return "MainMenu";
                    default:
                        Console.WriteLine("Please input a valid response");
                        Console.WriteLine("Please press <enter> to continue");
                        Console.ReadLine();
                        Console.Clear();
                    return "UserView";
                }
            }
        }
    }

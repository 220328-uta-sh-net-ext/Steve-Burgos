using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;

namespace UI
{
    public class AdminView : UIMenus
    {
        public void Display()
        {
            const string connectionStringFilePath = "../connections.txt";
            string connectionString = File.ReadAllText(connectionStringFilePath);
            Console.WriteLine("Enter <logout> to logout ");

            Console.WriteLine("Enter <search> for a new search ");

            


        }

        public string UserChoice()
        {
            const string connectionStringFilePath = "../connections.txt";
            string connectionString = File.ReadAllText(connectionStringFilePath);

            if (Console.ReadLine() is not string userInput)
                throw new InvalidDataException("end of input");
            switch (userInput)
            {
                case "search":
                    Console.Clear();
                    Console.Write("Search a User: ");
                    string searchItem = Console.ReadLine();

                    SQLDataLogic.SearchTable(connectionString, "users", "first name", searchItem);
                    Console.WriteLine();
                    return "AdminView";
                case "logout":
                    Console.Clear();
                    return "MainMenu";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press <enter> to continue");
                    Console.ReadLine();
                    Console.Clear();
                    return "AdminView";
            }

            
        }
    }
}

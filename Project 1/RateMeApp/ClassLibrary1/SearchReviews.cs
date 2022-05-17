using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;

namespace UI
{
    public class SearchReviews : UIMenus
    {

        public void Display()
        {
            const string connectionStringFilePath = "../connections.txt";
            string connectionString = File.ReadAllText(connectionStringFilePath);
            Console.Write("Enter the restaurant name: ");
            string name = Console.ReadLine();
            int id = (int)SQLDataLogic.getRestaurantID(connectionString, name);
            SQLDataLogic.SearchTableWithIntegerReviews(connectionString, "Reviews", "restaurant", id.ToString());

            // string commandString = $"SELECT* FROM [{tableName}] WHERE [{columnName}] LIKE searchItem";

            Console.Write("Press <Enter> to continue");

        }


        public string UserChoice()
        {
            if (Console.ReadLine() is not string userInput)
                throw new InvalidDataException("end of input");

            Console.Clear();
            return "UserView";
        }
    }
}

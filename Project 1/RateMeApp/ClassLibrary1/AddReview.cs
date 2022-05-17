using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;

namespace UI
{
    public class AddReview : UIMenus
    {
        public void Display()
        {
            const string connectionStringFilePath = "../connections.txt";
            string connectionString = File.ReadAllText(connectionStringFilePath);

            Console.WriteLine("Enter <back> to go back ");
            Console.Write("Enter restaurant name: ");
            string name = Console.ReadLine();
            int myID = (int)SQLDataLogic.getRestaurantID(connectionString, name);
            Console.Write("What score will you give between 1-5 ");
            string score = Console.ReadLine();
            while (score != "1" && score != "2" && score != "3" && score != "4" && score != "5")
            {
                Console.Clear();
                Console.WriteLine("Enter <back> to go back ");
                Console.WriteLine("Enter restaurant name: ");
                Console.Write("Give a valid input between 1-5: ");
                score = Console.ReadLine();
            }
            Console.Write("Write a review: ");
            string review = Console.ReadLine();
            

            SQLDataLogic.AddReview(connectionString, myID.ToString(), score, review); ;


        }

        public string UserChoice()
        {

            Console.Clear();
            return "UserView";
        }

    }
}

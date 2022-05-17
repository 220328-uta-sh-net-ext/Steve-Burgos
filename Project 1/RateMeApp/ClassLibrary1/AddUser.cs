using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;

namespace UI
{
    public class AddUser : UIMenus
    {
        public void Display()
        {
            const string connectionStringFilePath = "../connections.txt";
            string connectionString = File.ReadAllText(connectionStringFilePath);

            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter your email: ");
            string email = Console.ReadLine();
            Console.Write("Enter your phone number: ");
            string phone = Console.ReadLine();
            Console.Write("Enter your desired password: ");
            string password = Console.ReadLine();

            SQLDataLogic.AddUser(connectionString, firstName, lastName, email, phone, password );

        }


        public string UserChoice()
        {
            Console.Clear();
            return "MainMenu";
        }
    }
}

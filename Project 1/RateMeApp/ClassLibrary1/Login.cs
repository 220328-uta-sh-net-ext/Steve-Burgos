using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DL;


namespace UI
{
    public class Login : UIMenus
    {

        string adminValue = "";
        public void Display()
        {
            const string connectionStringFilePath = "../connections.txt";
            string connectionString = File.ReadAllText(connectionStringFilePath);

            Console.Write("Login: ");
            string? login = Console.ReadLine();


            Console.Write("Password: ");
            string? password = Console.ReadLine();

            string value = (string)SQLDataLogic.VerifyUser(connectionString, password, login);

            adminValue = (string)SQLDataLogic.VerifyAdmin(connectionString, password,login);
            //Console.WriteLine(SQLDataLogic.VerifyUser(connectionString, password, login));
            while (value == "FALSE")
            {
                Console.Clear();
                Console.Write("Login: ");
                login = Console.ReadLine();


                Console.Write("Password: ");
                password = Console.ReadLine();
                value = (string)SQLDataLogic.VerifyUser(connectionString, password, login);
            }


        }

        public string UserChoice()
        {
            Console.Clear();
            if (adminValue == "TRUE")
                return "AdminView";
            
      
            return "UserView";
        }
    }
}

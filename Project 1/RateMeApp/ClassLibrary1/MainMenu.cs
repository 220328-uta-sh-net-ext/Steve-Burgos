using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public class MainMenu : UIMenus
    {

        public void Display()
        {
            Console.WriteLine("Enter <0> for New User");
            Console.WriteLine("Enter <1> for Existing User");
        }


        public string UserChoice()
        {
            if (Console.ReadLine() is not string userInput)
                throw new InvalidDataException("end of input");

            switch (userInput)
            {
                case "0":
                    Console.Clear();
                    return "AddUser";
                case "1":
                    Console.Clear();
                    return "Login";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press <enter> to continue");
                    Console.ReadLine();
                    Console.Clear();
                    return "MainMenu";

            }
        }
    }
}

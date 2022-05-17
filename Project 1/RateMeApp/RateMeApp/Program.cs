global using Serilog;
using DL;
using UI;
using System.ComponentModel;

const string connectionStringFilePath = "../connections.txt";
string connectionString = File.ReadAllText(connectionStringFilePath);


//create and configure our logger
Log.Logger = new LoggerConfiguration()
    //.WriteTo.Console().MinimumLevel.Debug()
    .WriteTo.File("./Logs/logs.txt").MinimumLevel.Debug().MinimumLevel.Information()// we want to save the logs in this file
    .CreateLogger();



bool repeat = true;
UIMenus menu = new MainMenu();

while (repeat)
{
    menu.Display();
    string ans = menu.UserChoice();

    switch (ans)
    {

        case "MainMenu":
            Log.Debug("Displaying Main menu to the user");
            Log.Information("Displaying Main menu to the user");
            menu = new MainMenu();
            break;
        case "AdminView":
            Log.Debug("Displaying Admin menu to the user");
            Log.Information("Displaying Admin menu to the user");
            menu = new AdminView();
            break;
        case "UserView":
            Log.Debug("Displaying UserView menu to the user");
            Log.Information("Displaying UserView menu to the user");
            menu = new UserMenu();
            break;
        case "LoginMenu":
            Log.Debug("Displaying LoginMenu menu to the user");
            Log.Information("Displaying LoginMenu menu to the user");
            menu = new Login();
            break;
        case "Login":
            Log.Debug("Displaying Login menu to the user");
            Log.Information("Displaying Login menu to the user");
            menu = new Login();
            break;
        case "AddUser":
            Log.Debug("Displaying AddUser menu to the user");
            Log.Information("Displaying NewUser menu to the user");
            menu = new AddUser();
            break;
        case "AddReview":
              Log.Debug("Displaying AddReview menu to the user");
              Log.Information("Displaying AddReview menu to the user");
            menu = new AddReview();
            break;
        case "SearchReviews":
              Log.Debug("Displaying SearchReview menu to the user");
              Log.Information("Displaying SearchReview menu to the user");
            menu = new SearchReviews();
            break;
        case "SearchRestaurant":
              Log.Debug("Displaying SearchRestaurant menu to the user");
              Log.Information("Displaying SearchRestaurant menu to the user");
            menu = new SearchRestaurant();
            break;
        default:
            Console.WriteLine("View does not exist");
            Console.WriteLine("Please press <enter> to continue");
            Console.ReadLine();
            break;
    }
}
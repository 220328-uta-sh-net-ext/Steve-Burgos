using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateMeApp
{
    public class Connection
    {
        const string connectionStringFilePath = "../connections.txt";
        public static string connectionString = File.ReadAllText(connectionStringFilePath);
    }
}

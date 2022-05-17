namespace Connections
{
    public class ConnectionSQL
    {
        const string connectionStringFilePath = "../../../../connections.txt";
        public static string connectionString = File.ReadAllText(connectionStringFilePath);
    }
}
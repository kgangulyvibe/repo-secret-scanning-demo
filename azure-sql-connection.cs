// Example C# file with Azure SQL connection string leaked
using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string connString = "Server=tcp:myazuresql.database.windows.net,1433;Initial Catalog=mydb;Persist Security Info=False;User ID=sqladmin;Password=SuperSecretPassword123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            Console.WriteLine($"Leaked Azure SQL Connection String: {connString}");
        }
    }
}

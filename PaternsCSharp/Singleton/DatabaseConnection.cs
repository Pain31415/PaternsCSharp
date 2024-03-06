using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternsCSharp.Singleton
{
    public class DatabaseConnection
    {
        private static DatabaseConnection instance;

        private DatabaseConnection() { }

        public static DatabaseConnection GetInstance()
        {
            if (instance == null)
            {
                instance = new DatabaseConnection();
            }
            return instance;
        }

        public void Connect(string connectionString)
        {
            Console.WriteLine("Connecting to database with connection string: " + connectionString);
        }

        public void Disconnect()
        {
            Console.WriteLine("Disconnecting from database");
        }

        public void ExecuteQuery(string query)
        {
            Console.WriteLine("Executing query: " + query);
        }
    }
}

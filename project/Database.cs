using System.Data.SQLite;
using System.IO;

namespace NutriApp
{
    class Database
    {
        public SQLiteConnection myConnection;

        public Database()
        {
            myConnection = new SQLiteConnection("Data Source = database.sqlite3");
            if (!File.Exists("./database.sqlite3"))
            {
                SQLiteConnection.CreateFile("database.sqlite3");
                System.Console.WriteLine("Database file has been created.");
            }
            else 
            {
                System.Console.WriteLine("Database has been already created!");
            }
            
        }

    }
}

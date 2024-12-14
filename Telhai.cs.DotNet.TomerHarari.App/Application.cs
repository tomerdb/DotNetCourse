using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telhai.cs.DotNet.TomerHarari.Db;
using Telhai.cs.DotNet.TomerHarari.Infrastracture;

namespace Telhai.cs.DotNet.TomerHarari.App
{
    /// <summary>
    /// Entry point for the application, demonstrating database connection,
    /// command execution, and logging functionalities.
    /// </summary>
    class Application
    {
        /// <summary>
        /// Main method that initiates database connection, executes a SQL command,
        /// and logs any connection or execution errors.
        /// </summary>
        /// <param name="args">Command-line arguments.</param>
        public static void Main(string[] args)
        {
            SQLDb sQLDb = new SQLDb();

            // Attempt to connect to the database.
            bool isConnected = sQLDb.Connect("123.133.11.199");
            if (!isConnected)
            {
                Logger.Log("Failed to connect to the database");
            }

            // Attempt to execute a SQL command.
            isConnected = sQLDb.Execute("insert into table values(1,2,3)");
            if (!isConnected)
            {
                Logger.Log("Error executing command");
            }

            // Close the database connection.
            sQLDb.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telhai.cs.DotNet.TomerHarari.Infrastracture
{
    /// <summary>
    /// Provides logging functionality for recording messages with timestamps.
    /// </summary>
    public class Logger
    {
        /// <summary>
        /// Logs a message to the console, appending a timestamp in ISO 8601 format.
        /// </summary>
        /// <param name="message">The message to log.</param>
        public static void Log(string message)
        {
            Console.WriteLine(message + ":" + DateTime.Now.ToString("o"));
        }
    }
}

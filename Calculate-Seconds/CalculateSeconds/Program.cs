using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSeconds
{
    /// <summary>
    /// Integer Data Types Program Code
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demonstrates Integer Data Type
        /// </summary>
        /// <param name="args">Command Line Arguments</param>
        static void Main(string[] args)
        {
            int totalSecondsPlayed = 100;
            const int SecondsPerMinute = 60;

            // Calculate Minutes and Seconds Played
            int minutesPlayed = totalSecondsPlayed / SecondsPerMinute;
            int secondsPlayed = totalSecondsPlayed % SecondsPerMinute;

            // Print Results
            Console.WriteLine("Minutes Played : " + minutesPlayed);
            Console.WriteLine("Seconds Played : " + secondsPlayed);
            Console.WriteLine();
        }
    }
}

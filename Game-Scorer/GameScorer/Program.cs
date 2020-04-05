using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScorer
{
    /// <summary>
    /// Main Class
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main Method to Calculate Score
        /// </summary>
        /// <param name="args">Command Line Arguments</param>
        static void Main(string[] args)
        {
            int score = 1997;
            int totalSecondsPlayed = 10478;

            // Calculate and Print points per second
            float pointsPerSecond = (float)score / totalSecondsPlayed;
            Console.WriteLine("Points per Second : " + pointsPerSecond);
            Console.WriteLine();
        }
    }
}

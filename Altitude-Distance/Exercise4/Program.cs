using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    /// <summary>
    /// Main Program
    /// </summary>
    class Program
    {
        /// <summary>
        /// Program Implementation
        /// </summary>
        /// <param name="args">Command Line Arguments</param>
        static void Main(string[] args)
        {
            // Prompt for and get the altitude for a location as an int.
            int firstAltitude;
            Console.Write("Enter First Altitude : ");
            firstAltitude = int.Parse(Console.ReadLine());

            // Prompt for and get the altitude for a second location as an int.
            int secondAltitude;
            Console.Write("Enter Second Altitude : ");
            secondAltitude = int.Parse(Console.ReadLine());

            // Calculate and display the altitude change you'd experience moving from the first point to the second point.
            int altitudeChange;

            //if (firstAltitude > secondAltitude)
            //{
            //    altitudeChange = firstAltitude - secondAltitude;
            //    Console.WriteLine("Change in Altitude : " + altitudeChange);
            //}
            //else
            //{
                altitudeChange = secondAltitude - firstAltitude;
                Console.WriteLine("Change in Altitude : " + altitudeChange);
            //}

            Console.WriteLine();
        }
    }
}

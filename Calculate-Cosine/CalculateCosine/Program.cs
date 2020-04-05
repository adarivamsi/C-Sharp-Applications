using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalculateCosine
{
    /// <summary>
    /// Main Program
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main Class
        /// </summary>
        /// <param name="args">Command Line Arguments</param>
        static void Main(string[] args)
        {
            // Calculate and Print Cosine of 45 degrees
            float Cosine = (float)Math.Cos(45 * Math.PI / 180);
            Console.WriteLine("Cosine of 45 Degrees : " + Cosine);
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    /// <summary>
    /// Main Program
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main Method
        /// </summary>
        /// <param name="args">Command Line Arguments</param>
        static void Main(string[] args)
        {
            // Prompt for and get an angle in degrees and store it in a float variable.
            float angle;
            Console.Write("Enter the value of the Angle : ");
            angle = float.Parse(Console.ReadLine());

            // Calculate and display the cosine and sine of the angle.
            float angleCon = angle * (float)Math.PI / 180;

            float Sine = (float)Math.Sin(angleCon);
            float Consine = (float)Math.Cos(angleCon);

            Console.WriteLine("Sine(" + angle + ") is : " + Sine);
            Console.WriteLine("Cosine(" + angle + ") is : " + Consine);

            Console.WriteLine();
        }
    }
}

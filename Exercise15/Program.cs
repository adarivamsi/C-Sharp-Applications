using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("∗∗∗∗∗∗∗∗∗∗∗∗∗∗");
            Console.WriteLine("Menu:");
            Console.WriteLine("1 − NewGame");
            Console.WriteLine("2 − LoadGame");
            Console.WriteLine("3 − Options");
            Console.WriteLine("4 − Quit");
            Console.WriteLine("∗∗∗∗∗∗∗∗∗∗∗∗∗∗");

            int answer = int.Parse(Console.ReadLine());

            if (answer == 1)
            {
                Console.WriteLine("Starting Game......");
            }

            else if (answer == 2)
            {
                Console.WriteLine("Loading Game......");
            }

            else if (answer == 3)
            {
                Console.WriteLine("Loading Options......");
            }

            else if (answer == 4)
            {
                Console.WriteLine("Quitting Game......");
            }

            else
            {
                Console.WriteLine("Invalid Input......");
            }

            switch (answer)
            {
                case 1:
                    Console.WriteLine("Starting Game......");
                    break;
                case 2:
                    Console.WriteLine("Loading Game......");
                    break;
                case 3:
                    Console.WriteLine("Loading Options......");
                    break;
                case 4:
                    Console.WriteLine("Quitting Game......");
                    break;
                default:
                    Console.WriteLine("Invalid Inout......");
                    break;

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{    
    /// <summary>
    /// Exercise 9 
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demonstrates using custom classes
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // create a new deck and tell the deck to print itself
            Deck deck = new Deck();
            deck.Print();
            Console.WriteLine();

            // tell the deck to shuffle and print itself
            deck.Shuffle();
            deck.Print();
            Console.WriteLine();

            // take the top card from the deck and print the card rank and suit
            Card topCard1 = deck.TakeTopCard();
            Console.WriteLine(topCard1.Rank + " is the Top Card with " + topCard1.Suit);
            Console.WriteLine();

            // take the top card from the deck and print the card rank and suit
            Card topCard2 = deck.TakeTopCard();
            Console.WriteLine(topCard2.Rank + " is the Top Card with " + topCard2.Suit);
            Console.WriteLine();
        }
    }
}

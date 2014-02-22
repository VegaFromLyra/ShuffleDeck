using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Write a method to shuffle a deck of cards - in other words, each of the 52! permutations of the deck 
// has to be equally likely. 
// You are given a random number generator that is perfect. 

namespace ShuffleDeck
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cards = { 1, 2, 3, 4, 5 };
            ShuffleDeck(cards);

            Console.WriteLine("Shuffle deck is");

            for (int i = 0; i < cards.Length; i++)
            {
                Console.Write(cards[i] + " ");
            }

            Console.WriteLine();
        }

        static void ShuffleDeck(int[] cards)
        {
           int max = cards.Length;
           Random randomObject = new Random();
           for(int i = 0; i < cards.Length - 1; i++)
           {
               int rand = randomObject.Next(i + 1, max);

               int temp = cards[rand];
               cards[rand] = cards[i];
               cards[i] = temp;
           }
        }
    }
}

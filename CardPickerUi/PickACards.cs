using System;
using System.Collections.Generic;
using System.Linq;

namespace PickACard
{

    public static class PickCards
    {
        static Random random = new Random();
        public static void PrintNumber(int card)
        {
            List<int> numbers = new List<int>();
            while (numbers.Count() < card)
            {
                numbers.Add(card);
            }
            foreach (int number in numbers)
            {
                Console.WriteLine($"Picked {PickANumber(number)}{PickASuite(number)}");
            }
        }

        private static string PickANumber(int number)
        {
            int digit = random.Next(1, 14);
            if (digit == 1) { return "Aces"; }
            else if (digit == 11) return "Jack"; 
            else if (digit == 12) return "Queen"; 
            else if (digit == 13) return "King";
            else return digit.ToString();
        }

        private static string PickASuite(int number)
        {
            int digit = random.Next(1, 5);
            if (digit == 1) return " of Hearts.";
            else if (digit == 2) return " of Spades.";
            else if (digit == 3) return " of Clubs.";
            else return " of Diamonds. ";
        }
    }
}
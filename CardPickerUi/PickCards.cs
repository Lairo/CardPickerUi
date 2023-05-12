using System;
using System.Collections.Generic;
using System.Linq;

namespace CardPickerUi
{

    public static class PickCards
    {
        static Random random = new Random();
        public static string[] PrintNumber(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = PickANumber() + PickASuite();
            }

            return pickedCards;
        }

        private static string PickANumber()
        {
            int digit = random.Next(1, 14);
            if (digit == 1) { return "Aces"; }
            else if (digit == 11) return "Jack"; 
            else if (digit == 12) return "Queen"; 
            else if (digit == 13) return "King";
            else return digit.ToString();
        }

        private static string PickASuite()
        {
            int digit = random.Next(1, 5);
            if (digit == 1) return " of Hearts.";
            else if (digit == 2) return " of Spades.";
            else if (digit == 3) return " of Clubs.";
            else return " of Diamonds. ";
        }
    }
}
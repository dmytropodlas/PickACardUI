using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickACardUI
{
    class CardPicker
    {
        static Random random = new Random();

        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }
            return pickedCards;
        }

        private static string RandomSuit()
        {
            // получить случайное число от 1 до 4
            int value = random.Next(1, 5);
            // если это 1, вернуть строку Spades
            if (value == 1) return "Spades";
            // если это 2, вернуть строку Hearts
            if (value == 2) return "Hearts";
            // если это 3, вернуть строку Clubs
            if (value == 3) return "Clubs";
            // если выполнение продолжается, вернуть строку Diamonds
            return "Diamonds";
        }

        private static string RandomValue()
        {
            // получить число от 1 до 13
            int value = random.Next(1, 14);
            // если это 1, вернуть строку Ace
            if (value == 1) return "Ace";
            // если это 11, вернуть строку Jack
            if (value == 11) return "Jack";
            // если это 12, вернуть строку Queen
            if (value == 12) return "Queen";
            // если это 13, вернуть строку King
            if (value == 13) return "King";
            // если выполнение продолжается, вернуть value приобразовавши в строку
            return value.ToString();
        }
    }
}

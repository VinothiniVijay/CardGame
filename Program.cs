using System;
using System.Collections.Generic;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int CardCount = 0;
            CardDeck cardDeck = new CardDeck();
            List<Card> hand = new List<Card>();

            List<Card> shuffledCard = cardDeck.ShuffleCards();
            Console.WriteLine("\nSHUFFLED CARDS:");

            for (int i = 0; i < shuffledCard.Count; i++)
            {
                Console.WriteLine("{0} of {1}", shuffledCard[i].Value, shuffledCard[i].Suit);
            }

            CardCount = cardDeck.GetNoOfCardsToDraw();
            hand = cardDeck.DrawCards(CardCount);

            Console.WriteLine("\n\nSORTED CARDS IN HAND:");

            for (int i = 0; i < hand.Count; i++)
            {
                Console.WriteLine("{0} of {1}", hand[i].Value, hand[i].Suit);
            }

            hand = cardDeck.ResetDeck();

            Console.WriteLine("\n\n\nCARDS IN HAND AFTER RESET:");

            for (int i = 0; i < hand.Count; i++)
            {
                Console.WriteLine("{0} of {1}", hand[i].Value, hand[i].Suit);
            }

            Console.ReadKey();            
        }
    }
}

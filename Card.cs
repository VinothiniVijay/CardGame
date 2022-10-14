using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Card
    {
        private readonly CardSuit _suit;
        private readonly CardValue _value;

        public Card(int suit, int value)
        {
            _suit = (CardSuit)(suit);
            _value = (CardValue)(value);
        }

        public CardSuit Suit
        {
            get { return _suit; }
        }

        public CardValue Value
        {
            get { return _value; }
        }
        public enum CardSuit
        {
            Clubs = 0,
            Diamonds = 1,
            Hearts = 2,
            Spades = 3,
        }
        public enum CardValue
        {
            Ace = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Jack = 11,
            Queen = 12,
            King = 13,
        }

    }
}

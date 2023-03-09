using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Card
    {
        public enum Number
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

        public enum Suit
        {
            Club = 1,
            Diamond = 2,
            Heart = 3,
            Spade = 4,
        }

        public Number _Number { get; set; }

        public Suit _Suit { get; set; }

        public override string ToString()
        {
            return $"{_Number} of {_Suit}s"; //returns card in readable format
        }
    }
}
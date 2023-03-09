using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Card
    {   //creates a list of card values
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
        //creates a list of suits
        public enum Suit
        {
            Club = 1,
            Diamond = 2,
            Heart = 3,
            Spade = 4,
        }

        public Number _Number { get; set; }
        //puts the Number and Suit into the card
        public Suit _Suit { get; set; }
        //presents the card in the format "Value" of "Suit"s
        public override string ToString()
        {
            return $"{_Number} of {_Suit}s"; //returns card in readable format
        }
    }
}
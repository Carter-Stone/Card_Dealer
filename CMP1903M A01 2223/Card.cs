using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    //assigns an int to each string
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
    //constructs a card
    public class Card
    {
        //Base for the Card class.
        public string _Number {get; set;}
        public string _Suit {get; set;}

        public override string toString()
        {
            return $"{Number} of {Suit}s"; //returns card in readable format
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Card
    {
    //assigns an int to each string
        private enum Number
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
        private enum Suit
        {
            Club = 1,
            Diamond = 2,
            Heart = 3,
            Spade = 4,
        }
    //constructs a card

        //Base for the Card class.
        public string _Number
        {
            get {return Number; }
            set {Number = value; }
        }

        public string _Suit
        {
            get {return Suit;}
            set {Suit = value;}
        }
    }

       // public override Card tostring() //was 'string toString'
       // {
       //     return $"{_Number} of {_Suit}s"; //returns card in readable format
       // }
    }
}

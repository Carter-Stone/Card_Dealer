using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public enum Number
        {
            Ace = 1,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King,
            
        }
        public enum Suit
        {
            Club,
            Diamond,
            Heart,
            Spade,
        }

    public class Card
    {
        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4
        //The 'set' methods for these properties could have some validation
        public string _Suit {get; set;}
        public string _Value {get; set;}

        public override string toString();
        {
            return $"{Rank} of {Suits}s";
        }
    }
}

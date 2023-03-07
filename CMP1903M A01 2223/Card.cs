﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
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
            Club = 20,
            Diamond = 30,
            Heart = 40,
            Spade = 50,
        }

    public class Card
    {
        //Base for the Card class.
        //The 'set' methods for these properties could have some validation
        public string _Value {get; set;}

        public override string toString()
        {
            return $"{Rank} of {Suits}s";
        }
    }
}

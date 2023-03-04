using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        //Base for the Card class.
        //Value: numbers 1 - 13
        protected int _number = "Unknown";
        //Suit: numbers 1 - 4
        //The 'set' methods for these properties could have some validation
        public int number 
        { 
            get
            {
                return _number;
            }
            set
            {
                _number = value;
            } 
        }
        public int Suit { get; set; }
    }
}

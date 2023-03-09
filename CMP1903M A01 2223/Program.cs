using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CMP1903M_A01_2223.Card;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main()
        {
            Pack pack = new Pack(); //create pack
            pack.shuffleCardPack(1); //shuffle
            List<Card> hand = pack.dealCard(2); //deal 2
            foreach(Card card in hand)
            {
                Console.WriteLine(card); //print hand
            }
        }
    }
}

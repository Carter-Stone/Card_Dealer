using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static static void Main()
        {
            Pack pack = new Pack(); //create pack
            pack.shuffleCardPack(ShuffleType.Riffle); //shuffle
            List<Card>[] hand = pack.Deal(2); //deal 2
            foreach(Card card in hand)
            {
                Console.WriteLine(Card); //print hand
            }
        }
    }
}

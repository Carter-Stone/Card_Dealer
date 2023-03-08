using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
            Pack pack = new Pack();
            pack.shuffleCardPack(ShuffleType.Riffle);
            pack.dealCard(10);
            Console.WriteLine(Card);

           // var card1 = new Card("Generic card");
           // Console.writeLine("card Name = " + Card.getname());
        }
    }
}

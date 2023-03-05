using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public enum ShuffleType
    {
        Riffle,
        FisherYates
    }

    class Pack
    {
       private List<Card> _cards = new List<Card>() ;

        public Pack()
        {
            //Initialise the card pack here
            foreach (string _Suit in string.GetValues(typeof(_suit)))
            {
                foreach (string _Number in string.GetValues(typeof(_number)))
                {
                    _cards.Add(new Card {Suit = _Suit, Number = _number});
                }
            }
        }

        public static bool shuffle(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            switch (shuffleType)
            {
                case ShuffleType.Riffle:
                    Riffle();
                    break;
                case ShuffleType.FisherYates:
                    FisherYates();
                    break;
                default:
                    throw new ArgumentException("invalid shuffle type");
            }
        }
        private void Riffle()
        {
            List<Card> shuffledCards = new List<Card>();
            int halfIndex = _cards.Count/2;
            for (int i = 0; i < halfIndex; i++)
            {
                shuffledCards.Add(_cards[i]);
                shuffledCards.Add(_cards[i + halfIndex]);
            }
            if (_cards.Count % 2 !=0)
            {
                shuffledCards.Add(_cards.Last());
            }
            _cards = shuffledCards;
        }
        private void FisherYates()
        {
            Random random = new Random();
            int n = _cards.Count;
            while (n>1)
            {
                n--;
                int k = random.Next(n+1);
                _cards card = _cards[k];
                _cards[n] = card;
            }
        }
        public static Card dealCard()
        {
            //Deals one card

        }
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
        }
    }
}

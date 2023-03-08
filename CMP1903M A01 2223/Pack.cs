using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public enum ShuffleType
    {
        Riffle = 1,
        FisherYates = 2,
        None = 3,
    }

    public class Pack
    {
       private List<Card> _cards = new List<Card>();

        public Pack()
        {
            //Initialise the card pack here
            foreach (Suit _Suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Number _Number in Enum.GetValues(typeof(Number)))
                {
                    _cards.Add(new Card {Suit = _Suit, Number = _Number});
                }
            }
        }

        public void shuffleCardPack(int typeofShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            switch (ShuffleType)
            {
               case ShuffleType.Riffle:
                    Riffle();
                    break;
                case ShuffleType.FisherYates:
                    FisherYates();
                    break;
                case ShuffleType.None:
                break;
                default:
                throw new ArgumentException("invalid shuffle type");
            }
        }
        public void Riffle()
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
        public void Deal()
        {
            //Error Handling
            if(_cards.Count == 0)
            {
                throw new Exception("No cards in deck");
            }
            //Deals one card
            var TopCard = _cards[0];
            _cards.RemoveAt(0);
            return TopCard;

        }
        
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
            if (amount > _cards.Count || amount < 1)
            {
                throw new ArgumentException("Insufficient amount of cards");
            }

            List<Card> dealtCards = new List<Card>();
            for (int i = 0; i < amount; i++)
            {
                dealtCards.Add(deal());
            }
            return dealtCards;
        }
    }
}

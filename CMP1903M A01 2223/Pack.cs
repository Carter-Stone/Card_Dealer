using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Pack
    {
        List<Card> _cards = new List<Card>();
        public Pack()
        {
            //creates a pack of cards, one instance for each number of each suit
            foreach (Card.Suit _Suit in Enum.GetValues(typeof(Card.Suit)))
            {
                foreach (Card.Number _Number in Enum.GetValues(typeof(Card.Number)))
                {
                    _cards.Add( new Card { _Suit = _Suit, _Number = _Number });
                }
            }
        }

    //searches for a match and carries out the corresponding shuffle
    public void shuffleCardPack(int typeofShuffle)
        {
            if (typeofShuffle == 1){
            _Riffle();
            }
            else if (typeofShuffle == 2){
            _FisherYates();
            }
            else if (typeofShuffle == 3){
            }
            else{ //Error handling
            throw new ArgumentException("invalid shuffle type");
            }
        }
        public void _Riffle() //splits the pack in half and interweaves them
        {
            List<Card> shuffledCards = new List<Card>();
            int halfIndex = _cards.Count/2;
            for (int i = 0; i < halfIndex; i++)
            {
                shuffledCards.Add(_cards[i]);
                shuffledCards.Add(_cards[i + halfIndex]);
            }
            if (_cards.Count % 2 ==1)
            {
                shuffledCards.Add(_cards.Last());
            }
            _cards = shuffledCards;
        }
        private void _FisherYates() //Takes the top card and swaps it out with a random card in the pack
        {
            Random random = new Random();
            int n = _cards.Count;
            while (n>0) //runs until all are shuffled
            {
                n--;
                int k = random.Next(n+1);
                Card card = _cards[k];
                _cards[k] = _cards[n];
                _cards[n] = card;
            }
        }
        public Card Deal()
        {
            //Error Handling
            if(_cards.Count == 0)
            {
                throw new Exception("No cards in deck");
            }
            //Deals one card
            var topCard = _cards[0];
            _cards.Remove(topCard);
            return topCard;

        }
        
        public List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
            if (amount > _cards.Count || amount < 1)
            {   //Error handling
                throw new ArgumentException("Insufficient amount of cards");
            }

            List<Card> dealtCards = new List<Card>();
            for (int i = 0; i < amount; i++)
            {
                dealtCards.Add(Deal()); //runs 'deal' method until desired 'ammount' are dealt
            }
            return dealtCards;
        }
    }
}

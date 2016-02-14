using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardLib10
{
    public delegate void LastCardDrawnHandler(Deck currentDeck);


    public class Deck : ICloneable
    {
        public event LastCardDrawnHandler LastCardDrawn;

        public object Clone()
        {
            Deck newDeck = new Deck(cards.Clone() as Cards);
            return newDeck;
        }
        private Deck(Cards newCards)
        {
            cards = newCards;
        }
        
        
        //private Card[] cards;
        private Cards cards = new Cards();

        public Deck()
        {
            //cards = new Card[52];
            for(int suitVal = 0; suitVal < 4; suitVal++)
            {
                for(int rankVal = 0; rankVal < 13; rankVal++)
                {
                    //cards[suitVal * 13 + rankVal - 1] = new Card((Suit)suitVal, (Rank)rankVal);
                    cards.Add(new Card((Suit)suitVal, (Rank)rankVal));
                }
            }
        }

        public Deck(bool isAceHigh): this()
        {
            Card.isAceHigh = isAceHigh;
        }

        public Deck(bool useTrumps, Suit trump): this()
        {
            Card.useTrumps = useTrumps;
            Card.trump = trump;
        }

        public Deck(bool isAceHigh, bool useTrumps, Suit trump): this()
        {
            Card.isAceHigh = isAceHigh;
            Card.useTrumps = useTrumps;
            Card.trump = trump;
        }

        public Card GetCard(int cardNum)
        {
            if (cardNum >= 0 && cardNum <= 51)
            {
                if ((cardNum == 51) && (LastCardDrawn != null))
                    LastCardDrawn(this);
                return cards[cardNum];
            }
            else throw new CardOutOfRangeException((Cards)cards.Clone());
                
        }

        public void Shuffle()
        {
            //Card[] newDeck = new Card[52];
            Cards newDeck = new Cards();
            bool[] assigned = new bool[52];
            Random sourceGen = new Random();

            for(int i = 0; i < 52; i++)
            {
                int sourceCard = 0;
                bool foundCard = false;
                while (foundCard == false)
                {
                    sourceCard = sourceGen.Next(52);
                    if (assigned[sourceCard] == false)
                        foundCard = true;
                }
                assigned[sourceCard] = true;
                //newDeck[sourceCard] = cards[i];
                newDeck.Add(cards[sourceCard]);
            }
            newDeck.CopyTo(cards);
        }
    }
}
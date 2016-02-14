using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardLib10
{
    public class Card : ICloneable
    {
        public static bool useTrumps = false;
        public static Suit trump = Suit.Club;
        public static bool isAceHigh = true;

        public object Clone()
        {
            return MemberwiseClone();
        }

        public Rank rank;
        public Suit suit;

        public static bool operator ==(Card card1, Card card2)
        {
            return (card1.suit == card2.suit) && (card1.rank == card2.rank);
        }
        public static bool operator !=(Card card1, Card card2)
        {
            return !(card1 == card2);
        }
        public override bool Equals(object card)
        {
            return this == (Card)card;
        }
        public override int GetHashCode()
        {
            return 13 * (int)rank + (int)suit;
        }
        public static bool operator >(Card card1, Card card2)
        {
            if(card1.suit == card2.suit)
            {
                if (isAceHigh)
                {
                    if(card1.rank == Rank.Ace)
                    {
                        if (card2.rank == Rank.Ace)
                            return false;
                        else return true;
                    }
                    else
                    {
                        if (card2.rank == Rank.Ace)
                            return false;
                        else
                            return (card1.rank > card2.rank);
                    }
                }
                else
                {
                    return (card1.rank > card2.rank);
                }

            }
            else
            {
                if (useTrumps && (card2.suit == Card.trump))
                    return true;
                else return false;
            }
        }

        public static bool operator <(Card card1, Card card2)
        {
            return !(card1 >= card2);
        }
        public static bool operator >=(Card card1, Card card2)
        {
            if (card1.suit == card2.suit)
            {
                if (isAceHigh)
                {
                    if (card1.rank == Rank.Ace)
                    {
                        if (card2.rank == Rank.Ace)
                            return false;
                        else return true;
                    }
                    else
                    {
                        if (card2.rank == Rank.Ace)
                            return false;
                        else
                            return (card1.rank >= card2.rank);
                    }
                }
                else
                {
                    return (card1.rank >= card2.rank);
                }

            }
            else
            {
                if (useTrumps && (card2.suit == Card.trump))
                    return true;
                else return false;
            }
        }

        public static bool operator <=(Card card1, Card card2)
        {
            return !(card1 > card2);
        }


        private Card()
        {
            
        }

        public Card(Suit newSuit, Rank newRank)
        {
            suit = newSuit;
            rank = newRank;
        }

        public override string ToString()
        {
            return "The " + rank + " of " + suit + "s";
        }
    }
}
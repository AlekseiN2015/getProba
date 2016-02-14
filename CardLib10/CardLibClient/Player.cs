using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardLib10;

namespace CardLibClient
{
    class Player
    {
        private Cards hand;
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
        }
        public Cards PlayHand
        {
            get
            {
                return hand;
            }
        }
        private Player()
        {

        }

        public Player(string newName)
        {
            name = newName;
            hand = new Cards();
        }

        public bool HasWon()
        {
            bool won = true;
            Suit match = hand[0].suit;
            for(int i = 1; i < hand.Count; i++)
            {
                won &= hand[i].suit == match;
            }
            return won;
        }
    }
}

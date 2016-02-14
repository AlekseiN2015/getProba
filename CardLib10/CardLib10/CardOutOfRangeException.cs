using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLib10
{
    public class CardOutOfRangeException : ApplicationException
    {
        private Cards deckContens;
        private Cards DeckContens
        {
            get
            {
                return deckContens;
            }
        }

        public CardOutOfRangeException(Cards sourceDeckContens) : base("В колоде имеется лишь 52 карты!")
        {
            deckContens = sourceDeckContens;
        }
    }
}

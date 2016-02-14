using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardLib10;

namespace CardClient10
{
    class Program
    {
        static void Main(string[] args)
        {
            Card.isAceHigh = true;
            Console.WriteLine("Туз старшая карта.");

            Card.useTrumps = true;
            Card.trump = Suit.Club;
            Console.WriteLine("Трефы - козырная масть!");

            Card card1, card2, card3, card4, card5;
            card1 = new Card(Suit.Club, Rank.Five);
            card2 = new Card(Suit.Club, Rank.Five);
            card3 = new Card(Suit.Club, Rank.Ace);
            card4 = new Card(Suit.Heart, Rank.Ten);
            card5 = new Card(Suit.Diamond, Rank.Ace);

            Console.WriteLine("{0} == {1} ? {2}", card1.ToString(), card2.ToString(), card1 == card2);
            Console.WriteLine("{0} != {1} ? {2}", card1.ToString(), card3.ToString(), card1 != card3);
            Console.WriteLine("{0}.Equals({1}) ? {2}", card1.ToString(), card4.ToString(), card1.Equals(card4));
            Console.WriteLine("{0} > {1} ? {2}", card1.ToString(), card2.ToString(), card1 > card2);
            Console.WriteLine("{0} <= {1} ? {2}", card1.ToString(), card3.ToString(), card1 <= card3);
            Console.WriteLine("{0} > {1} ? {2}", card1.ToString(), card4.ToString(), card1 > card4);
            Console.WriteLine("{0} > {1} ? {2}", card4.ToString(), card1.ToString(), card4 > card1);
            Console.WriteLine("{0} > {1} ? {2}", card4.ToString(), card5.ToString(), card4 > card5);
            Console.WriteLine("{0} > {1} ? {2}", card5.ToString(), card4.ToString(), card5 > card4);
            Console.ReadKey();
        }
    }
}

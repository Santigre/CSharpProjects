using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackJack
{
    class Program
    {

        static void Main(string[] args)
        {   

            Deck deck = new Deck();

            //int count = deck.cards.count(x => x.face == face.ace);

            //List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();

            //foreach( Card card in newList)
            //{
            //  Console.WriteLine(card.Face);
            //}

            //Console.WriteLine(count);

            List<int> numberList = new List<int>() {1,2,3,4,5,66};

            int sum = numberList.Where(x => x > 3).Sum();

            //int min = numberList.Min();

            //int min = numberList.Max();

            Console.WriteLine(sum);


            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
            }
    }
}

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


            //card.Suit = Suit.Clubs;
            //int underlyingValue = (int Suit

            //blackJAck game = new blackJAck();
            //game.Players = new List<string> { "Bob", "Bill", "Joe" };
            //game.Listplayer();
            //game.Play();
            //Console.ReadLine();
            //Game game = new blackJAck();
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "Bob";
            //game += player;
            //game -= player;





            //blackJAck game = new blackJAck();
            //game.Players = new List<string>() { "Bill", "Bob", "John" };
            //game.Listplayer();
            //Console.ReadLine();



            Deck deck = new Deck();
            deck.Shuffle(3);

            //Player player = new Player();

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
            //deck.Cards = new List<Card>();



            //Card cardOne = new Card();
            //cardOne.Face = "Queen";
            //cardOne.Suit = "Spades";

            //deck.Cards.Add(cardOne);

            //Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);

        }



        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for(int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}

using System;
using Casino;
using Casino.blackJack;


namespace blackJack
{
    class Program
    {

        static void Main(string[] args)
        {


            Console.WriteLine("Welcome player!! What is your name!?!?");
            string playerName = Console.ReadLine();
            Console.WriteLine("How much money you got?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello {0}. Would you like to join a game of Black Jack right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if(answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                Game game = new blackJAck();
                game += player;
                player.isActivleyPLaying = true;
                while (player.isActivleyPLaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing");
            }

            Console.WriteLine("Get out of here {0}! ", playerName);
            Console.ReadLine();

        }
    }
}

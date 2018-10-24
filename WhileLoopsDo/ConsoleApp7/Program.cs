using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Try to guess my color!");

            bool colorBool = false;

            // With do statment
            do
            {

                string userColor = Console.ReadLine();
                string myColor = "red";


                if (userColor == myColor)
                {
                    Console.WriteLine("That is correct! You picked my favorit color");
                    userColor = Console.ReadLine();
                    colorBool = true;

                }


                else
                {
                    Console.WriteLine("Thats  nice color but its not my color.");
                    Console.WriteLine("Try to guess my color!");
                }
            }

            while (colorBool == false);
            {

            }
            // Just while loop
            //while(colorBool == false)
            //{

            //    string userColor = Console.ReadLine();
            //    string myColor = "red";


            //    if (userColor == myColor)
            //    {
            //        Console.WriteLine("That is correct! You picked my favorit color");
            //        userColor = Console.ReadLine();
            //        colorBool = true;

            //    }


            //    else
            //    {
            //        Console.WriteLine("Thats  nice color but its not my color.");
            //        Console.WriteLine("Try to guess my color!");
            //    }


            //}
            Console.ReadLine();
        }
    }
}

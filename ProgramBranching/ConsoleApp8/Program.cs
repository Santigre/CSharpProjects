using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express.Please follow the instructions below");
            Console.WriteLine("How heavy is your package?");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            if( packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                System.Environment.Exit(1);
            }

            Console.WriteLine("What is the width of your package?");
            int packageWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the height of your package?");
            int packageHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the length of your package?");
            int packageLength = Convert.ToInt32(Console.ReadLine());

            if( (packageWidth + packageHeight + packageLength) > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                System.Environment.Exit(1);
            }

            double dimensionTotal = ((packageWidth + packageHeight + packageLength) * packageWeight) / 100;
            Console.WriteLine("$" + dimensionTotal + " Is the quote for your package!");
            Console.WriteLine("Thank you!");

            Console.ReadLine();

        }
    }
}

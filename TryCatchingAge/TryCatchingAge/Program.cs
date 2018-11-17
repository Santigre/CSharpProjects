using System;

namespace TryCatchingAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there! Please enter your age");

            int userAge = int.Parse(Console.ReadLine());

            bool validAge = false;


            while (!validAge)
            {
                if (userAge <= 0)
                {
                    Console.WriteLine("Im sorry please enter a number that is over 0!");
                    Console.ReadLine();
                    return;
                }
                try
                {

                    DateTime thisYear = DateTime.Now;
                    DateTime birthYear = thisYear.AddYears(-userAge);
                    Console.WriteLine("You were born in the year: {0}", birthYear.Year);
                    validAge = true;
                }
                catch(Exception)
                {
                    Console.WriteLine("Something went wrong. Try again!");
                }
            }
            Console.ReadLine();
        }
    }
}

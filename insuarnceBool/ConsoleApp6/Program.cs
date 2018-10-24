using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string userAge = Console.ReadLine();
            Console.WriteLine("Have you ever had a DUI?  True or False");
            string userDui = Console.ReadLine();
            Console.WriteLine("How many speeding tickets do you have?");
            string userTickets = Console.ReadLine();

            int age = Convert.ToInt16(userAge);
            bool compareAge = age > 15;
            //Console.WriteLine(compareAge);


            bool dui = Convert.ToBoolean(userDui);
            bool duiCheck = dui != true;
            //Console.WriteLine(duiCheck);

            int tickets = Convert.ToInt16(userTickets);
            bool compareTickets = tickets < 3;
            // Console.WriteLine(compareTickets);

            bool result = compareAge && duiCheck && compareTickets;
            Console.WriteLine("Qualified? " + result);







            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Stufent Dailey Report");
            Console.WriteLine("What course are you in? ");
            string courseName = Console.ReadLine();
            Console.WriteLine("What page number are you on?");
            string pageNumber = Console.ReadLine();
            int number = Convert.ToInt32(pageNumber);
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false”.");
            string help = Console.ReadLine();
            bool anyHelp = Convert.ToBoolean(help);
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string experiance = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedBack = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hoursStudy = Console.ReadLine();
            decimal hours = Convert.ToDecimal(hoursStudy);
            Console.WriteLine("“Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");


                



            Console.ReadLine();

        }
    }
}

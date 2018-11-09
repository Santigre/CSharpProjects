using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumDays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the currant day of the week!");
            List<string> emptyList = new List<string>();
            string userEntry = Console.ReadLine();

            try
            {
                DayOfWeek DayName = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), userEntry);
                if (Enum.IsDefined(typeof(DayOfWeek), DayName))
                {
                    Console.WriteLine("{0} is the current date", DayName);
                }
                else
                {
                    Console.WriteLine("{0} is not a day of the week", userEntry);
                }


            }
            catch(ArgumentException)
            {
                Console.WriteLine("Try entering an actual day of the week");
            }

            Console.ReadLine();

        }
        enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wendsday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}

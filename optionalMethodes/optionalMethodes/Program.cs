using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace optionalMethodes
{
    class Program
    {
        static void Main(string[] args)
        {
            opting choiceOne = new opting();

            Console.WriteLine("Please enter a number!! ");
            int userFirst = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter an other number if you want. ");
            string userSecond = Console.ReadLine();
            int value;

            if (int.TryParse(userSecond, out value) && value >= 1 && value <=3)
            {
                int secondNumber = Convert.ToInt32(userSecond);
                Console.WriteLine(choiceOne.Choices(x: userFirst, y: secondNumber));
            }
            else
            {
                Console.WriteLine(choiceOne.Choices(x: userFirst));
            }



            Console.ReadLine();

        }
    }
}

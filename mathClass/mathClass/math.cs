using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathClass
{
    public class mathing
    {
        //public int userInput()
        //{
        //    Console.WriteLine("Enter a number!");
        //    int userNumber = Convert.ToInt32(Console.ReadLine());
        //    return userNumber;
        //}

        public int adding(int x)
        {
            mathing math1 = new mathing();


            int add = x + 10;
            Console.WriteLine("Your number plue 10 is " + add);

            return add;
        }

        public int subtracting(int x)
        {
            mathing math2 = new mathing();

            int subtract =  x - 3;
            Console.WriteLine("Your number minuse 3 is " + subtract);

            return subtract;
        }

        public double dividing(int x)
        {
            mathing math3 = new mathing();

            double divide = x / 2;
            Console.WriteLine("Your number divided by 2 is " + divide);

            return divide;
        }
    }


}

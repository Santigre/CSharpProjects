using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodeOutputs
{
    class Passing 
    {
        
        public static void number(out int x)
        {
            Console.WriteLine("Enter a number please!");
            x = Convert.ToInt32(Console.ReadLine());
        }



        public int dividing(int y)
        {
            number(out y);
            int output = y / 2;
            return output;

        }
        public int dividing(string c)
        {
            int a = Convert.ToInt32(c);
            number(out a);
            int output = a / 2;
            return output;

        }

        //public void text()
        //{
        //    Console.WriteLine("Your number divided by 2 is: ");
        //    Console.WriteLine(dividing());
        //}
    }
}

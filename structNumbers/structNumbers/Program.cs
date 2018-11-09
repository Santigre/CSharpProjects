using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Number i = new Number();

            i.Amount = 12;

            Console.WriteLine("My struct value is {0}", i.Amount);
            Console.ReadLine();
        }
    }
}

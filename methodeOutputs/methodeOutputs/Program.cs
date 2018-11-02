using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodeOutputs
{
    class Program
    {
        static void Main(string[] args)
        {
            Passing math = new Passing();
            int output = math.dividing();
            Console.WriteLine("Your number divided by 2 is: " + output);


            Console.ReadLine();
        }
    }
}

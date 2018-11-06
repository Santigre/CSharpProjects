using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenaricEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> Things1 = new Employee<string>();
            Employee<int> Things2 = new Employee<int>();

            Things1.Things.Add("Hats");
            Things1.Things.Add("Balls");
            Things1.Things.Add("Cars");

            Things2.Things.Add(1);
            Things2.Things.Add(3);
            Things2.Things.Add(87);

            foreach(string thing in Things1.Things)
            {
                Console.WriteLine(thing);
            }

            foreach (int thing in Things2.Things)
            {
                Console.WriteLine(thing);
            }


            Console.ReadLine();
        }
    }
}

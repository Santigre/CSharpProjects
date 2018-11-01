using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathClass
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            mathing math1 = new mathing();
            mathing math2 = new mathing();
            mathing math3 = new mathing();

            math1.adding(x:userNumber);
            math2.subtracting(x:userNumber);
            math3.dividing(x:userNumber);




            Console.ReadLine();
        }
    }
}

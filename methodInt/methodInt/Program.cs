using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodInt
{
    class Program
    {
        static void Main(string[] args)
        {
            intMath math = new intMath();
            intMath math2 = new intMath();
            intMath math3 = new intMath();

            int firstNumber = 12;
            decimal secondNumber = 44;
            string thirdNumber = "1";

            Console.WriteLine( math.firstMath(x: firstNumber));
            Console.WriteLine( math.firstMath(x: secondNumber));
            Console.WriteLine(math.firstMath(x: thirdNumber));
            Console.ReadLine();
        }
    }
}

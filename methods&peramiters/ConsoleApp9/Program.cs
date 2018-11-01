using classOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twoInts
{
    public class Program
    {
        static void Main(string[] args)
        {
            Class1 firstNumber = new Class1();

            Console.WriteLine("enter a number!");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a number!");
            int numberTwo = Convert.ToInt32(Console.ReadLine());

            Class1.Numbers(x:numberOne, y:numberTwo);

            Console.ReadLine(); 
        }
    }
}

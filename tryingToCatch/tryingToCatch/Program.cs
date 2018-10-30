using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        List<decimal> numbers = new List<decimal> { 1, 2, 3, 4, 5, 6};
        Console.WriteLine("Please pick a number to divide by");

        try
        {
            decimal userNumber = Convert.ToDecimal(Console.ReadLine());

            foreach (decimal x in numbers)
            {
                decimal divided = x / userNumber;
                Console.WriteLine(divided);
            }
        }
        catch(FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }

        catch(DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.ReadLine();

    }
}

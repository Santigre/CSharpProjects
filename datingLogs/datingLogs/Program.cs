using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datingLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);

            Console.WriteLine("Please enter a number");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            DateTime plusHours = DateTime.Now.AddHours(userNumber);
            Console.WriteLine(plusHours);

            Console.ReadLine();
        }
    }
}

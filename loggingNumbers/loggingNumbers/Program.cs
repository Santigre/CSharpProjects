using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace loggingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey you!!! Enter a number now!!!");
            string userNumber = Console.ReadLine();
            File.WriteAllText(@"C:\Repositories\CSharpProjects\loggingNumbers\numberLogs\loggedNumbers.txt", userNumber);
            string readfile = File.ReadAllText(@"C:\Repositories\CSharpProjects\loggingNumbers\numberLogs\loggedNumbers.txt");
            Console.WriteLine(readfile);
            Console.ReadLine();
        }
    }
}

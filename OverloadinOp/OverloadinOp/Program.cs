using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();

            employee1.FirstName = "Sample";
            employee1.LastName = "Student";
            employee1.Id = 1;
            employee1.SayName();

            employee2.FirstName = "NotSample";
            employee2.LastName = "NotStudent";
            employee2.Id = 1;
            employee2.SayName();

            if (employee1.Id == employee2.Id)
            {
                Console.WriteLine("These employees have the same id");
            }
            else
            {
                Console.WriteLine("These employees dont have the same id");
            }

            Console.ReadLine();
        }
    }
}

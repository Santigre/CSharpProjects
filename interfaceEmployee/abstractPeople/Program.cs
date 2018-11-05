using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractPeople
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            IQuittable quittable = new Employee();

            employee.firstName = "Sample";
            employee.lastName = "Student";

            employee.SayName();
            
            quittable.Quit(employee);

            Console.ReadLine();
        }
    }
}

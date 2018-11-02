using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peopleInherate
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Individual = new Employee();
            Individual.FirstName = "Sample";
            Individual.LastName = "Student";
            Individual.SayName();

            Console.ReadLine();
        }
    }
}

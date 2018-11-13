using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopingLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employees = new List<Employee>();

            var Names = new [] { "Brad Trake", "Bill Bob", "Joe Moor",
                "Joe Banks", "Brian Tilly", "Mandy Woohaa",
                "Randy Jons", "Ark Band","Mark Trant",
                "Willy Wanka" };
            var Ids = new [] { 1, 7, 2, 5, 9, 12, 4, 3, 99, 10 };

            var combined = Names.Zip(Ids, (w, n) => new { Words = w, Numbers = n });
            foreach (var x in combined)
            {

                Employee employee = new Employee();

                employee.Name = x.Words;
                employee.ID = x.Numbers;
                Employees.Add(employee);
                //Console.WriteLine(employee.Name + " " + employee.ID);
            }
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(Employees[i].Name);
            //}




            //List<string> newList = new List<string>();
            //List<int> idList = new List<int>();

            //foreach (string x in Names)
            //{
            //    if (x.StartsWith("Joe"))
            //    {
            //        newList.Add(x);
            //        Console.WriteLine(x);
            //    }
            //}
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(Employees[i].Name);
            //}


            List<Employee> findJoe = Employees.Where(x => x.Name.StartsWith("Joe")).ToList();
            List<Employee> bigID = Employees.Where(x => x.ID >= 5).ToList();

            for (int i = 0; i < findJoe.Count; i++)
            {
                Console.WriteLine("These are joes " + findJoe[i].Name);
            }
            for (int i = 0; i < bigID.Count; i++)
            {
                Console.WriteLine("Names with ids bigger than 5: " + bigID[i].Name + " This employee has the id number: " + Employees[i].ID);
            }


            //foreach (string x in Employee)
            //{

            //    string lastIndex = x.Remove(0, (x.Length - 1));
            //    int idValue = Convert.ToInt32(lastIndex);
            //    idList.Add(idValue);
            //}


            //List<int> IdOverFive = idList.Where(x => x > 5).ToList();
            //foreach (int x in IdOverFive)
            //{
            //    Console.WriteLine(x);
            //}


            Console.ReadLine();
        }
    }
}

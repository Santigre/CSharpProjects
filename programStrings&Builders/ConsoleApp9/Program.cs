using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            string welcome = "Hello there ";
            string firstName = " Santiago ";
            string lastName = " Beltran";

            firstName = firstName.ToUpper();

            Console.WriteLine(welcome + firstName + lastName);

            StringBuilder sb = new StringBuilder();

            sb.Append("\n \t This is my first string builder that i have ever done! ");
            sb.Append("\n Idk what this does but i hope i am doing this the right way");
            sb.Append("\n Just Testing some thing out hoping nothing blows up ");
            sb.Append("\n Just hoping this works so i can move on");

            Console.WriteLine(sb);

            
                
            Console.ReadLine();
        }
    }
}

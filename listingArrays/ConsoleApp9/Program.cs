using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {

        string[] nameArray = { "Bob", "Bill", "Happy", "Willy", "Gill" };

        Console.WriteLine("Pick an muber between 0 and 4 to get a name.");
        int userName = Convert.ToInt32(Console.ReadLine());
        if (userName <= 4)
        {
            Console.WriteLine("Your new name is " + nameArray[userName] + ". Congradualtaions.");
        }
        else
        {
            Console.WriteLine("Ooopps You picked an invalide number. You no longer have a name");
        }

        int[] ageArray = { 54, 32, 18, 9, 26 };

        Console.WriteLine("Now pick a number between 0 and 4 to get an age");
        int userAge = Convert.ToInt32(Console.ReadLine());
        if (userName <= 4)
        {
            Console.WriteLine("And you are now " + ageArray[userAge] + " years old!");
        }
        else
        {
            Console.WriteLine("You picked an invalide number. I guess you dont excist now");
        }

        List<string> animalList = new List<string>();
        animalList.Add("Dog");
        animalList.Add("Bull");
        animalList.Add("Yeti");
        animalList.Add("Cow");
        animalList.Add("Goat");

        Console.WriteLine("BONUS CHOICE!!!!! PICK AN OTHER NUMBER BETWEEN 0 AND 4");
        int userAnimal = Convert.ToInt32(Console.ReadLine());
        if (userAnimal <= 4)
        {
            Console.WriteLine("Forget everything everything you know. You are now a " + animalList[userAnimal] + ". Now Be free!!!!!!");
        }
        else
        {
            Console.WriteLine("You are no fun. See ya later");
        }


        Console.ReadLine();
    }
}


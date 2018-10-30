using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
     {
        //string[] myArray = { "wing", "bird", "hot", "vibrant", "Chili" };
        //Console.WriteLine("Please type a word for me!?!");
        //string userWords = Console.ReadLine();

        //for(int wordPossition = 0; wordPossition < myArray.Length; wordPossition++ )
        //{
        //    Console.WriteLine(myArray[wordPossition] + " " + userWords);

        //}
        //Console.ReadLine();





        ////////Infinite loop///////////

        //for ( ; ; )
        //{
        //    Console.WriteLine("idk what is happening");
        //}


        //////fixed loop//////
        //for(int wordPossition = 0; wordPossition <= 4; wordPossition++)

        //{
        //    Console.WriteLine(myArray[wordPossition]);
        //    Console.WriteLine("It works Now");

        //}
        //Console.ReadLine();

        ///////Guessing the word in the list//////////

        //List<string> myWords = new List<string> { "Floop", "Wham", "Butter", "Cars", "Wings", "Floop" };
        //Console.WriteLine("Try to guess one of my words");
        //string userWords = Console.ReadLine();
        //bool correctWord = false;

        //while(!correctWord)
        //{
        //    for (int word = 0; word <= 5; word++)
        //    {
        //        if (userWords == myWords[word])
        //        {
        //            Console.WriteLine("You guessed the word: " + myWords[word] + " at index: " + word);
        //            correctWord = true;
        //        }
        //    }
        //    if(correctWord == false)
        //    {
        //        Console.WriteLine("This word is not on my list.");
        //        Console.ReadLine();
        //        break;

        //    }
        //}
        //Console.ReadLine();


        ////////For Each loops///////////////
        List<string> myList = new List<string> { "Car", "Wheel", "Hood", "Wheel", "Break", "Car" };
        Console.WriteLine("Try to guess my words");
        string userWord = Console.ReadLine();
        int count = 0;

        foreach (string word in myList)
        {
            if (word == userWord)
            {
                count++;
            }
        }
        Console.WriteLine("The word: " + userWord + " shows up in the list " + count + " times");
        Console.ReadLine();


    }
}

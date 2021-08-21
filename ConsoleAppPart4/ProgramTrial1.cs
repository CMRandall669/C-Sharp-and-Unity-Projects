using System;
using System.Collections.Generic;

namespace ConsoleAppPart4
{
    class Program
    {
        static void Main()
        {
            List<string> animals = new List<string>() { "bear", "cat", "bird", "dog", "fish", "snake" };
            Console.WriteLine("Please enter the name of an animal: ");
            string thisOne = Console.ReadLine();

            foreach (string animal in animals)
            {
                if (animal == thisOne)
                {
                    Console.WriteLine(thisOne + " is number " + animals.IndexOf(thisOne) + " on the list");
                    return;
                }
                Console.ReadLine();
            }


            foreach (string animal in animals)
            {
                if (animal != thisOne)
                {
                    Console.WriteLine("Not here");
                    return;
                }
                Console.ReadLine();
            }
        }
    }
}

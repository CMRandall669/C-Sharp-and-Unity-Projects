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

            for (int i = 0; i < animals.Count; i++)
            {
                if (animals[i] == thisOne)
                {
                    Console.WriteLine("Match found at index: " + i);
                }
            }

            if (animals.Contains(thisOne)) {
                Console.WriteLine("Not Here");
            }
        }
    }
}

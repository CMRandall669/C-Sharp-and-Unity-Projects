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
                    bool isHere = true;
                    if (isHere == true)
                    {
                        Console.WriteLine(thisOne + " is number " + animals.IndexOf(thisOne) + " on the list");
                        Console.ReadLine();

                    }

                }

                else
                {
                    if (animal != thisOne)
                    {
                        bool isHere = false;
                        if (isHere == false)
                        {
                            Console.WriteLine("Not here");
                            Console.ReadLine();

                        }

                    }
                }

            }
        }
    }
}

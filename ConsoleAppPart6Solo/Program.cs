using System;
using System.Collections.Generic;

namespace ConsoleAppPart6Solo
{
    class Program
    {
        static void Main(string[] args)
        {
             List<string> names = new List<string>() { "Lawrence", "Adams", "Pitt", "Tom", "Jerry", "Adams", "Jack" };
            List<string> names2 = new List<string>() { };

            foreach (string i in names)
            {
                if (names2.Contains(i))
                {
                    Console.WriteLine("The name " + i + " has appeared before.");
                }
                else
                {
                    Console.WriteLine("The name " + i + " has not appeared before");
                }
                names2.Add(i);
            }
        }
    }
}

﻿using System;

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
                    Console.WriteLine("The name Adams has already appeared");
                }

                if (!names2.Contains(i))
                {
                    names2.Add(i);
                }



            }
        }
    }
}

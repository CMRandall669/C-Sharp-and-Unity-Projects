using System;
using System.Collections.Generic;

namespace ConsoleApp_6_Part
{
    class Program
    {
        static void Main()
        {

            //ASSIGNMENT 1
            //string[] firstName = { "Tomeka", "Freeman", "Antoine", "Krystle", "Charity" };

            //Console.WriteLine("Please type a last name for the family");
            //string lastName = Console.ReadLine();

            //for (int i = 0; i < firstName.Length; i++)
            //{
            //    Console.WriteLine(firstName[i] + " " + lastName);

            //}

            //Console.ReadLine();





            //ASSIGNMENT 2 AND 3
            //HERE'S AN INFINITE LOOP

            //Console.WriteLine("Infinite loop!!!!");
            //for (int a = 0; a < 10; a--)
            //{
            //    Console.WriteLine("value : {0}", a);
            //}
            //Console.ReadLine();


            //THIS IS THE CORRECTED INFINITE LOOP ALSO IS A LOOP USING THE LESS THAN OPERATOR

            //Console.WriteLine("Fixed infinite loop and using the less than operator");
            //for (int a = 0; a < 10; a++)
            //{
            //    Console.WriteLine("value : {0}", a);
            //}
            //Console.ReadLine();


            //LOOP USES LESS THAN OR EQAUL TO OPERATOR
            //Console.WriteLine("Using Less than or equal to operator");
            //for (int a = 0; a <= 10; a++)
            //{
            //    Console.WriteLine("value : {0}", a);
            //}
            //Console.ReadLine();







            //ASSIGNMENT PART 4 
            //List<string> animals = new List<string>() { "bear", "cat", "bird", "dog", "fish", "snake" };
            //Console.WriteLine("Please enter the name of an animal: ");
            //string thisOne = Console.ReadLine();

            //for (int i = 0; i < animals.Count; i++)
            //{
            //    if (animals[i] == thisOne)
            //    {
            //        Console.WriteLine("Match found at index: " + i);
            //    }
            //}

            //if (!animals.Contains(thisOne))
            //{
            //    Console.WriteLine("No match found in the index");
            //}
            //Console.ReadLine();







            //ASSIGNMENT PART 5

            //List<string> muscleCars = new List<string>();
            //muscleCars.Add("Mustang");
            //muscleCars.Add("Corvette");
            //muscleCars.Add("Camaro");
            //muscleCars.Add("Challenger");
            //muscleCars.Add("Corvette");
            //muscleCars.Add("Trans Am");
            //muscleCars.Add("Charger");
            //muscleCars.Add("GTO");

            //Console.WriteLine("Please enter Corvette to see 2 results or any other for 1 result:");
            //string carPick = Console.ReadLine();

            //foreach (string car in muscleCars)
            //{

            //    if (car == carPick)
            //    {

            //        for (int motor = muscleCars.IndexOf(carPick);
            //            motor >= 0;
            //            motor = muscleCars.IndexOf(carPick, motor + 1))
            //        {
            //            Console.WriteLine("This car appears at index " + motor);

            //        }
            //        Console.ReadLine();
            //        return;
            //    }
            //}

            //foreach (string car in muscleCars)
            //{
            //    if (car != carPick)
            //    {
            //        Console.WriteLine("This is not in the list");
            //        Console.ReadLine();
            //        return;
            //    }


            //}

            //ASSIGNMENT 6
            //List<string> names = new List<string>() { "Lawrence", "Adams", "Pitt", "Tom", "Jerry", "Adams", "Jack" };
            //List<string> names2 = new List<string>() { };

            //foreach (string i in names)
            //{
            //    if (names2.Contains(i))
            //    {
            //        Console.WriteLine("The name " + i + " has appeared before.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The name " + i + " has not appeared before");
            //    }
            //    names2.Add(i);
            //}












        }

    }
}


using System;
using System.Collections.Generic;

namespace ArraysSubmission
{
    class Program
    {
        static void Main()
        {
            string[] stringArray = { "Hank", "Peggy", "Bobby", "Rusty", "Bill", "Jeff" };
            int[] numArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            Console.WriteLine("Please select an index on the string array and reveal your favorite King of The Hill Character.");
            int inputIndex = Convert.ToInt32(Console.ReadLine());
            if (inputIndex >= 0 && inputIndex < 6)
            {
                Console.WriteLine(stringArray[inputIndex] + " is you favorite King of The Hill Character");
            }
            else
            {
                if (inputIndex >= 6)
                {
                    Console.WriteLine("You have no favorite character because you picked a non exisiting index of the array.");
                }
            }
            Console.ReadLine();
            

            Console.WriteLine("Please select an index on the int array and reveal your favorite season of King of The Hill.");
            int numIndex = Convert.ToInt32(Console.ReadLine());
            if (numIndex >= 0 && numIndex < 13)
            {
                Console.WriteLine(numArray[numIndex] + " is the best season of King of The Hill");
            }
            else
            {
                if (numIndex >= 13)
                {
                    Console.WriteLine("You have no favorite season because you picked a non exisiting index of the array.");
                }
            }

            Console.ReadLine();
            List<string> Actors = new List<string>(6);
            Actors.Add("Mike Judge voiced Hank Hill");
            Actors.Add("Kathy Najimy voiced Peggy Hill");
            Actors.Add("Pamela Adion voiced Bobby Hill");
            Actors.Add("Johnny HardWick voiced Rusty");
            Actors.Add("Stephen Root voiced Bill");
            Actors.Add("Mike Judge voiced Jeff");

            Console.WriteLine("Please select an index on the string list and see the voice actors from King of The Hill.");
            int listIndex = Convert.ToInt32(Console.ReadLine());
            if (listIndex >= 0 && listIndex < 6)
            {
                Console.WriteLine(Actors[listIndex] + " on King of The Hill");
            }
            else
            {
                if (listIndex >= 6)
                {
                    Console.WriteLine("Nobody voiced a character who's index does not exist.");
                }
            }
            Console.ReadLine();





        }
    }
}

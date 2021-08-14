using System;

namespace BooleanLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Guess our hidden hidden number! Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            bool beatsIt = number == 52;

            do
            {
                switch (number)
                {
                    case 15:
                        Console.WriteLine("Too low");
                        Console.WriteLine("Guess another number:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 43:
                        Console.WriteLine("Getting warmer");
                        Console.WriteLine("Guess another number:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 51:
                        Console.WriteLine("Just a bit too low");
                        Console.WriteLine("Guess another number:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 52:
                        Console.WriteLine("That's the number congrats!");
                        beatsIt = true;
                        break;
                    default:
                        Console.WriteLine("Try again. That wasnt it.");
                        Console.WriteLine("Guess another number: ");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!beatsIt);

            Console.ReadLine();
            
        }
    }
}

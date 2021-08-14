using System;

namespace BooleanLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our guessing game. Please guess a number between 1 and 10");
            int number = Convert.ToInt32(Console.ReadLine());
            bool hasBeat = false;
            bool tryHard = false;


            while (!hasBeat)
                switch (number)
                {
                    case 1:
                        Console.WriteLine("That's too low try again.");
                        Console.WriteLine("Enter another number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 3:
                        Console.WriteLine("That's too low try again.");
                        Console.WriteLine("Enter another number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 4:
                        Console.WriteLine("That's too low try again.");
                        Console.WriteLine("Enter another number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 7:
                        Console.WriteLine("That's too low try again.");
                        Console.WriteLine("Enter another number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 9:
                        Console.WriteLine("That's too high try again.");
                        Console.WriteLine("Enter another number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 8:
                        Console.WriteLine("That's the correct number!");
                        hasBeat = true;
                        Console.WriteLine("Would you like to try hard mode? Please enter true or false.");
                        tryHard = Convert.ToBoolean(Console.ReadLine());
                        break;

                    default:
                        Console.WriteLine("Not it. Try again");
                        Console.WriteLine("Enter another number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                }

            if (tryHard == false)
            {
                Console.WriteLine("Thanks for playing!");
            }
            else
            {
                if (tryHard == true)
                    Console.WriteLine("Guess a number between 1 and 100! Enter a number: ");
                int number2 = Convert.ToInt32(Console.ReadLine());
                bool beatsIt = number2 == 52;

                do
                {
                    switch (number2)
                    {
                        case 15:
                            Console.WriteLine("Too low");
                            Console.WriteLine("Guess another number:");
                            number2 = Convert.ToInt32(Console.ReadLine());
                            break;

                        case 43:
                            Console.WriteLine("Getting warmer");
                            Console.WriteLine("Guess another number:");
                            number2 = Convert.ToInt32(Console.ReadLine());
                            break;

                        case 51:
                            Console.WriteLine("Just a bit too low");
                            Console.WriteLine("Guess another number:");
                            number2 = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 52:
                            Console.WriteLine("That's the number congrats! Thanks for playing!");
                            beatsIt = true;
                            break;
                        default:
                            Console.WriteLine("Try again. That wasnt it.");
                            Console.WriteLine("Guess another number: ");
                            number2 = Convert.ToInt32(Console.ReadLine());
                            break;
                    }
                }
                while (!beatsIt);
            }
                }
            }
        }
    


    

using System;

namespace ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to Package Express. Please follow the intructions below.");

            Console.WriteLine("What is the weight of the package?");
            int packageWeight = Convert.ToInt32(Console.ReadLine());
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else if (packageWeight <= 50) ;
            {
                Console.WriteLine("What is the width of the package?");
                int packageWidth = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is the height of the package?");
                int packageHeight = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is the length of the package?");
                int packageLength = Convert.ToInt32(Console.ReadLine());

                if (packageWidth + packageHeight + packageLength > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                
                else
                {
                    int packageDimensions = packageWidth * packageHeight * packageLength;
                    int packageDimWeight = packageDimensions * packageWeight;
                    int packageTotal = packageDimWeight / 100;

                    Console.WriteLine("Your estimated total for shipping is : $" + packageTotal);
                    Console.WriteLine("Thank you for your time!");
                    
                }
            }
  
            }
        }
    }


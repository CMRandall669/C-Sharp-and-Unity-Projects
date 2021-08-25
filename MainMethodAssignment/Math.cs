using System;
using System.Collections.Generic;
using System.Text;

namespace MainMethodAssignment
{
    public class Math
    {
        
        public int integerInput { get; set; }
        public decimal decimalInput { get; set; }
        public string stringInput { get; set; }
        public int loopCount = 4;
        public string userResult()
        {   
            for (int i = 0; i < loopCount ; i++)
            {
                if (i < 1)
                {
                    Console.WriteLine("Please enter a whole number: ");
                    int integerInput = Convert.ToInt32(Console.ReadLine());
                    int endResult1 = integerInput * 10;
                    Console.WriteLine("The number you entered times 10 equals:  " + endResult1);
                    Console.ReadLine();
                }

                else if (i < 2)
                {
                    Console.WriteLine("Please enter a number with a decimal value: ");
                    decimal decimalInput = Convert.ToDecimal(Console.ReadLine());
                    decimal endResult2 = decimalInput + 13;
                    Console.WriteLine("The decimal you entered plus 13 is:   " + endResult2);
                    Console.ReadLine();
                }



                else if (i < 3)
                {
                    Console.WriteLine("Please enter a word and we will check if it beats our number");
                    string stringInput = Convert.ToString(Console.ReadLine());
                    if (stringInput.Length > 4)
                    {
                        Console.WriteLine("The word " + stringInput + " is longer than 4 letters");
                    }

                    if (stringInput.Length <= 4)
                    {
                        Console.WriteLine("The word " + stringInput + " is at least 4 letters long.");
                    }
                    Console.ReadLine();
                    

                }
            }

            return"";

        }
        

    }
}
using System;
using System.Collections.Generic;

namespace ExceptionAppAssignment
{
    class Program
    {
        static void Main()
        {
            int[] numbersList = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };


            bool restart = false;
            do
            {
                restart = false;
                try
                {
                    Console.WriteLine("Please enter a number to divide each number in the list by: ");
                    int userNumber = Convert.ToInt32(Console.ReadLine());

                    foreach (int i in numbersList)
                    {
                        int result = i / userNumber;
                        Console.WriteLine(i + " divided by " + userNumber + " equals " + result);
                        Console.ReadLine();
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Please enter a whole number");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Please do not divide by zero");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("this is the end of the Try/Catch block and the app will restart.");
                    restart = true;
                }
            } while (restart);

        }
    }
}

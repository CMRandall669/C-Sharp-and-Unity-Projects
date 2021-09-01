using System;

namespace EnumsSubmission
{

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the current day of the week.");
                string currentday = Console.ReadLine();
                OneWeek.days day;

                if (Enum.TryParse<OneWeek.days>(currentday, out day))
                {
                    Console.WriteLine("Good job.  Today is " + currentday);
                    Console.ReadLine();
                }
                else
                {
                    throw new OverflowException(); 
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.ReadLine();
        }

    }
}
    


using System;

namespace Basic_Approval_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            bool hadDUI = true;

            Console.WriteLine("What is your age?");
            int driverAge = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("Have you ever had a DUI? Please enter true or false");
            hadDUI = Convert.ToBoolean(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            int speedTicket = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("Do you qualify for insurance?");

        }
    }
}

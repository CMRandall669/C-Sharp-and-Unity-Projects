using System;

namespace Basic_Approval_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            bool hadDUI = true;
            bool yayInsurance = true;
            int qualifyAge = 15;
            int speedNumber = 3;

            Console.WriteLine("Answer some questions to see if you qualify for insurance");

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
               if (driverAge > qualifyAge && hadDUI == false && speedTicket <= speedNumber)
            {
                yayInsurance = true;
                Console.WriteLine(yayInsurance);
            }
               else
            {
                yayInsurance = false;
                Console.WriteLine(yayInsurance);
            }

            Console.ReadLine();
            



      


        }
    }
}

using System;

namespace MathAndComparisonsOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymus Income Comparison Program");
            Console.ReadLine();

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate");
            int hoursPerson1 = 15;
            int hoursPerWeek1 = 40;
            Console.WriteLine("How much per hour: " + hoursPerson1);
            Console.WriteLine("How many hours per week: " + hoursPerWeek1);
            Console.ReadLine();

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate");
            int hoursPerson2 = 20;
            int hoursPerWeek2 = 40;
            Console.WriteLine("How much per hour: " + hoursPerson2);
            Console.WriteLine("How many hours per week: " + hoursPerWeek2);
            Console.ReadLine();

            int weeksPerYear = 52;
            int annualSalary1 = hoursPerson1 * hoursPerWeek1 * weeksPerYear;
            Console.WriteLine("Annual Salary of Person 1 is: " +annualSalary1);
            Console.ReadLine();

            int annualSalary2 = hoursPerson2 * hoursPerWeek2 * weeksPerYear;
            Console.WriteLine("Annual Salary of Person 2 is: " + annualSalary2);
            Console.ReadLine();

            bool makesMore = annualSalary1 > annualSalary2;
            Console.WriteLine("Does person 1 make more money than person 2?");
            Console.WriteLine(makesMore);
            Console.ReadLine();


        }
    }
}

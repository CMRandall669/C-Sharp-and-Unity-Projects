using System;

namespace MethodSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            twoNumber two = new twoNumber();
            Console.WriteLine("Please enter 2 numbers and see some multiplication in action");
            Console.WriteLine(two.mathAnswer());
            Console.ReadLine();

            
        }
    }
}

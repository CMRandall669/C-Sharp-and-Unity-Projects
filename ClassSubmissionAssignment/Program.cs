using System;

namespace ClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Divide divide = new Divide();

            Console.WriteLine("Please enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            

            divide.MathOperation(num);
            divide.Overload();

            Console.ReadLine();
        }
    }
}

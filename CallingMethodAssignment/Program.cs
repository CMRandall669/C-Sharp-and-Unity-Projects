using System;

namespace CallingMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Input input = new Input();
            input.firstNumber = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine(input.userResult());
            Console.WriteLine(input.userResult2());
            Console.WriteLine(input.userResult3());

            Console.ReadLine(); 
            
           

            




        }
    }
}

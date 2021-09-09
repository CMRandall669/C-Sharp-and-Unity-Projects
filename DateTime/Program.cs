using System;

namespace DateTimeSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
             DateTime dt = new DateTime();

            DateTime currentTime = DateTime.Now;
            Console.WriteLine(currentTime);
            Console.WriteLine("Please enter a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            DateTime newTime = currentTime.AddHours(userInput);
            Console.WriteLine("The date and time in " + userInput + " hours will be " + newTime);
            Console.ReadLine();
        }
    }
}

using System;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            bool needHelp = false; 

            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your Name is: " + yourName);
            Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("You are currently completing: " + courseName);
            Console.ReadLine();

            Console.WriteLine("What page number of the course are you on?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Current page number is: " + pageNumber);
            Console.ReadLine();

            Console.WriteLine("Have you ever had a DUI? \nPlease enter true or false.");
            needHelp = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Is there any positive experiences you'd like to share? Please give specfiics");
            string feedback = Console.ReadLine();
            Console.WriteLine("Thank you for submitting the feedback that reads: " + feedback);
            Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            int studyTime = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You studied for: " + studyTime + " hours");
            Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();

        }
    }
}



using System;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {

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
            string pageNumber = Console.ReadLine();
            Console.WriteLine("Current page number is: " + pageNumber);
            Console.ReadLine();

            Console.WriteLine("Do you need help with anything? Please answer true or false");
            bool needHelp = true;
            string helpStatus = Convert.ToString(needHelp);
            Console.WriteLine(helpStatus);
            Console.ReadLine();

            Console.WriteLine("Is there any positive experiences you'd like to share? Please give specfiics");
            string feedback = Console.ReadLine();
            Console.WriteLine("Thank you for submitting the feedback that reads: " + feedback);
            Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string studyTime = Console.ReadLine();
            Console.WriteLine("You studied for: " + studyTime + " hours");
            Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();

        }
    }
}



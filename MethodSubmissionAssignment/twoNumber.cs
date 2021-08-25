using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment
{
    public class twoNumber
    {
        public int numberOne { get; set; }
        public int numberTwo { get; set; }
        
        public string mathAnswer()
        {
            Console.WriteLine("Please enter the first number: ");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You enter " + numberOne + " as the first number.");
            

            int numberTwo;
            Console.WriteLine("Please enter a second number. You can leave this blank if you prefer");
            bool result = int.TryParse(Console.ReadLine(), out numberTwo);
            if (result)
            {

                Console.WriteLine("You entered " +numberTwo + " as the second number.");
                
                int numberThree = numberOne * numberTwo;
                Console.WriteLine("The product of " + numberOne + " and " + numberTwo + " is " + numberThree);
            }
            else
            {
                numberTwo = 0;
                Console.WriteLine("Because you didnt enter a number, we're just going to make this a " +numberTwo);
                
                int numberThree = numberOne * numberTwo;
                Console.WriteLine("Any number multiplied by " +numberTwo + " will always be " + numberThree + ": so " + numberOne + " multiplied by " + numberTwo + " will equal " + numberThree);
            }
            Console.ReadLine();

            





            return "Thanks for having fun with numbers!";
        }

    }
}

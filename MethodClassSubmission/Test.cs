using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassSubmission
{
    public class Test
    {
        public int NumberOne { get; set; }
        public int NumberTwo { get; set; }

        public void MathOperation()
        {

            Console.WriteLine("Please enter the first number: ");
            int NumberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You enter " + NumberOne + " as the first number.");

            Console.WriteLine("Please enter the second number: ");
            int NumberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You enter " + NumberTwo + " as the second number.");

            int NumberThree = NumberOne + 250;
            Console.WriteLine(NumberThree + " is the result of the first number plus 250 ");
            Console.WriteLine("The second integer you provided was " + NumberTwo);
            Console.ReadLine();

        }
        

    }
}

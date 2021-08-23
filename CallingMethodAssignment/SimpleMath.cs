using System;
using System.Collections.Generic;
using System.Text;

namespace CallingMethodAssignment
{

    public class Input 
    {
        public int userNumber()
        {
            Console.WriteLine("Enter a number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            return firstNumber;

            int userResult(int secondInteger = 10)
            {
                int endResult = firstNumber * secondInteger;
                Console.WriteLine(endResult);
                return userResult();
            }

           
        }
    }
}

  
    
    
   
    




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Employee : Person, IQuittable
    {
        public void Quit()
        {

            bool getMeOut = true;
            Console.WriteLine("Quit? true or false");
            getMeOut = Convert.ToBoolean(Console.ReadLine());
            if (getMeOut == true)
            {
                Console.WriteLine("End of program");
                return;
            }

            else if (getMeOut == false)
            {
                firstName = "Sample";
                lastName = "Student";
                SayName();
                
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public bool getMeOut { get; set; }

        public void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }

}
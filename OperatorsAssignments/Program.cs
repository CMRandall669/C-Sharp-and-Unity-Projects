using System;

namespace OperatorsAssignments
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.Id = 1;
            emp1.firstName = "Bob";
            emp1.lastName = "Jones";

            Employee emp2 = new Employee();
            emp2.Id = 1;
            emp2.firstName = "Bob";
            emp2.lastName = "Jones";

            if (emp1 == emp2)
            {
                Console.WriteLine("emp1 is equal to emp2");
            }
            else
            {
                Console.WriteLine("emp1 is not equal to emp2");
            }
            
        }
    }
}

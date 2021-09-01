using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            employee.things = new List<string>();
            Employee<int> employee2 = new Employee<int>();
            employee2.things = new List<int>();

            employee.things.Add("Jeff");
            employee.things.Add("Mark");
            employee.things.Add("George");

            employee2.things.Add(40);
            employee2.things.Add(60);
            employee2.things.Add(80);


            for (int i = 0; i < employee.things.Count; i++)
            {
                Console.WriteLine(employee.things[i].ToString() + ", " + employee2.things[i].ToString());
                
            }
            

            Console.ReadLine();



        }
    }
}

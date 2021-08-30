using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.Quit(employee);
            employee.firstName = "Sample";
            employee.lastName = "Student";
            
            Console.ReadLine();
        }
    }
}

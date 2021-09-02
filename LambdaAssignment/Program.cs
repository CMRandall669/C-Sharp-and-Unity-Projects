using System;
using System.Collections.Generic;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employee = new List<Employee>();
            List<string> joes = new List<string>();

            employee.Add(new Employee { Name = "Andy Warhol", Id = 1 });
            employee.Add(new Employee { Name = "Franklin Two", Id = 2 });
            employee.Add(new Employee { Name = "Zao Shang", Id = 3 });
            employee.Add(new Employee { Name = "Jackson Pollock", Id = 4 });
            employee.Add(new Employee { Name = "Agent K", Id = 5 });
            employee.Add(new Employee { Name = "Albus Dumbledore", Id = 6 });
            employee.Add(new Employee { Name = "Alan Rickman", Id = 7 });
            employee.Add(new Employee { Name = "Steve Buscemi", Id = 8 });
            employee.Add(new Employee { Name = "Joe Dirt", Id = 9 });
            employee.Add(new Employee { Name = "Joe Pistachio", Id = 10 });

            foreach (var hire in employee)
            {
                string newHire = Convert.ToString(hire);
                Console.WriteLine(newHire);
            }
            //Employee<string> employee2 = new Employee<string>();
            //employee2.entry = new List<string>() { "Andy Warhol", "Franklin Two", "Zao Shang", "Jackson Pollock", "Agent K",
            //"Albus Dumbledore", "Alan Rickman", "Steve Buscemi", "Joe Dirt",  "Joe Jonas"};








            Console.ReadLine();
        }
    }
}

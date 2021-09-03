using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employee = new List<Employee>();
            List<Employee> employeeJoe = new List<Employee>();
            List<Employee> employeeID = new List<Employee>();

            employee.Add(new Employee { firstName = "Andy", lastName = "Warhol", Id = 1 });
            employee.Add(new Employee { firstName = "Franklin", lastName = "Two", Id = 2 });
            employee.Add(new Employee { firstName = "Zao", lastName = "Shang", Id = 3 });
            employee.Add(new Employee { firstName = "Jackson", lastName = "Pollock", Id = 4 });
            employee.Add(new Employee { firstName = "Agent", lastName = "Kalvin", Id = 5 });
            employee.Add(new Employee { firstName = "Albus", lastName = "Dumbledore", Id = 6 });
            employee.Add(new Employee { firstName = "Alan", lastName = "Rickman", Id = 7 });
            employee.Add(new Employee { firstName = "Steve", lastName = "Buscemi", Id = 8 });
            employee.Add(new Employee { firstName = "Joe", lastName = "Dirt", Id = 9 });
            employee.Add(new Employee { firstName = "Joe", lastName = "Pistachio", Id = 10 });

            employee.ForEach(x =>
            {
                if (x.firstName == "Joe")
                {
                    employeeJoe.Add(x);

                    foreach (var joe in employeeJoe)
                    {
                        Console.WriteLine(joe.firstName);
                    }
                }

            }

            );

            employee.ForEach(x =>
            {
                if (x.Id > 5)
                {
                    employeeID.Add(x);

                    foreach (var number in employeeID)
                    {
                        Console.WriteLine(number.firstName);
                    }
                }
            }
            );
            

            //foreach (var hire in employee)
            //{
            //    if (hire.firstName == "Joe")
            //    {
            //        employeeJoe.Add(hire);
            //        Console.WriteLine(employeeJoe);
            //    }

            //}








        }
           
            
    }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    public class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Employee()
        {
        }

        public Employee(string Name, int Id)
        {
            Name = Name;
            Id = Id;
        }
    }
}

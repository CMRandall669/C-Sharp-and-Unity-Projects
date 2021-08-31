using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignments
{
    public class Employee : Person, IEquatable<Employee>
    {
       public int Id { get; set; }
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            if (emp1.Id.Equals(emp2.Id))
            {
                return true;
            }
            return false;
        }
       
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            if (!emp1.Id.Equals(emp2.Id))
            {
                return true;
            }
            return false;
        }

        public bool Equals(Employee other)
        {
            return other.Id.Equals(this.Id);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Employee);
        }

        //public override bool Equals(object obj)
        //{
        //    Employee employee = obj as Employee;

        //    if (employee != null)
        //    {
        //        return employee.Id.Equals(this.Id);
        //    }
        //    return false;
        //}

    }
}

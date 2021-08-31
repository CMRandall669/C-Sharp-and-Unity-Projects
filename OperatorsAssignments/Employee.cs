using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignments
{
    public class Employee1 : Test
    {
        string firstName = "Alan";
        string lastName = "Harper";

        public static bool operator ==(Employee1 employee1, Employee2 employee2)
        {
            return true;
        }

        public static bool operator !=(Employee1 employee1, Employee2 employee2)
        {
            return true;
        }

        public override bool Equals(object o)
        {
            return true;
        }

        public override int GetHashCode()
        {
            return 0;
        }
    }
}

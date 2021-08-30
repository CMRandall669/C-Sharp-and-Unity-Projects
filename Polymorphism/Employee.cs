using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodObjectAssignment
{
    public class Employee : Person, IQuittable
    {
        public void Quit(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
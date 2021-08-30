using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace Polymorphism
{
    public interface IQuittable
    {
        void Quit(Employee employee); 
    }
}

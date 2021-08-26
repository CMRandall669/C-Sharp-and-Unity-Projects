using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    public class Divide
    {
        public static int i;
        public void MathOperation(int num)
        {
            int num2 = num / 2;
            Console.WriteLine("The number " +num + " you entered divided by 2 is " +num2);
        }



        public int Overload()
        {
            return 0;
        }

        public int Overload(int a)
        {
            a = 10;
            return a;
        }
        public int Overload(int a, int b, int c)
        {
            a = 10;
            b = 20;
            c = 30;
            return a + b + c;
        }
        public int Overload(int a, int b, out int c)
        {

            a = 10;
            b = 10;
            c = a + b;
            return c;
        }

       
    }

    static class Locked
    {
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment16
{
    class assignment
    {
        public static void DivideTheTwo(int num, out int num0, int num2)
        {
            num0 = num / num2;
            Console.WriteLine(num + " divided by " + num2 + " equals " + num / num2);
        }

        public static double DivideTheTwo(double num3, double num4)
        {
            return num3 / num4;
        }
    }
}

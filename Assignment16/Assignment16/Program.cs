using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment16
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Please enter two numbers to get divided.");
            int num = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            assignment.DivideTheTwo(num, out int num0, num2);

            Console.WriteLine(assignment.DivideTheTwo(num, num2));
            Console.WriteLine("{0}", num0);
            Console.ReadLine();

            Console.WriteLine("Please enter two numbers to get divided.");
            double num3 = Convert.ToDouble(Console.ReadLine());
            double num4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(assignment.DivideTheTwo(num3, num4));
            Console.ReadLine();
        }
    }
}

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
            double num = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(assignment.divideTheTwo(num, num2));
            Console.ReadLine();

        }
    }
}

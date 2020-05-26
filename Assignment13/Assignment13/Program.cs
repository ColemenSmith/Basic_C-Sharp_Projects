using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to be put through a test.");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Now please enter a decimal number to go through a test.");
            decimal dec = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("And a final number to go through a test.");
            string written = Console.ReadLine();

            Console.WriteLine(num + " goes into the method and out comes: " + RandomOperation.multiplier(num));
            Console.ReadLine();
            Console.WriteLine(dec + " goes into the second method and out comes: " + RandomOperation.multiplier(dec));
            Console.ReadLine();
            Console.WriteLine(written + " goes into the third method and out comes: " + RandomOperation.multiplier(written));
            Console.ReadLine();
        }
    }
}

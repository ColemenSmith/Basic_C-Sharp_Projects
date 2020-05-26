using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Please enter one or two numbers, the second is optional.");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Would you like to enter a second number?");
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes")
            {
                Console.WriteLine("Enter your second number");
                int second = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(randomMethod.randomOperation(first, second));
            }
            else if (answer == "no")
            {
                Console.WriteLine(randomMethod.randomOperation(first));
            }
            Console.ReadLine();

        }
    }
}

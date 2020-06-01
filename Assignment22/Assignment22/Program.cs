using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Please enter a number.");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("It will be " + DateTime.Now.AddHours(number) + " in " + number + " hours.");

            Console.ReadLine();
        }
    }
}

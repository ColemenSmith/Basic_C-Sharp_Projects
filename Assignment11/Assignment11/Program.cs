using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] intArray = { 4, 7, 10, 15, 20 };

            Console.WriteLine("Entering try/catch.");
            Console.ReadLine();
            try
            {
                Console.WriteLine("Enter a number to divide into the list.");
                int dividend = Convert.ToInt32(Console.ReadLine());

                foreach (int num in intArray)
                {
                    Console.WriteLine(num / dividend);
                }
                Console.ReadLine();

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You cannot divide by zero");
                return;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter your choice as a whole number.");
            }
            finally
            {
                Console.ReadLine();
            }
            Console.WriteLine("Exiting try/catch");
            Console.ReadLine();
        }
    }
}

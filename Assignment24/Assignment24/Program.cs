using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment24
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Please tell me your age.");
                int age = int.Parse(Console.ReadLine());
                if (age < 1)
                {
                    throw new ArgumentOutOfRangeException();
                }
                int year = DateTime.Now.Year;
                int yearBorn = year - age;
                Console.WriteLine("You were born in " + yearBorn);
                Console.ReadLine();
            }   
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Your age must be above zero.");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Please write your age in just digits with no decimals added.");
                Console.ReadLine();
            }
        }
    }
}

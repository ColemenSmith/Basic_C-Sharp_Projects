using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18
{
    enum DaysOfTheWeek
    {
        monday = 0,
        tuesday = 1,
        wednesday = 2,
        thursday = 3,
        friday = 4,
        saturday = 5,
        sunday = 6
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What day of the week is it?");
            string value = Console.ReadLine().ToLower();

            DaysOfTheWeek day;
            try
            {
                day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), value);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.ReadLine();
        }
    }
}

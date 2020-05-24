using System;

namespace Assignment4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();
            Console.WriteLine("Person 1");
            
            Console.WriteLine("What is your hourly rate?");
            string hourlyRate = Console.ReadLine();
            int hourlyRateToInt = Int32.Parse(hourlyRate);

            Console.WriteLine("How many hours do you work per week?");
            string hoursPerWeek = Console.ReadLine();
            int hoursPerWeekToInt = Int32.Parse(hoursPerWeek);

            Console.WriteLine("Person 2");

            Console.WriteLine("What is your hourly rate?");
            string hourlyRate2 = Console.ReadLine();
            int hourlyRateToInt2 = Int32.Parse(hourlyRate2);

            Console.WriteLine("How many hours do you work per week?");
            string hoursPerWeek2 = Console.ReadLine();
            int hoursPerWeekToInt2 = Int32.Parse(hoursPerWeek2);

            Console.WriteLine("Annual salary of person 1: ");
            int annualSalary = (hourlyRateToInt * hoursPerWeekToInt) * 52;
            Console.WriteLine(annualSalary);

            Console.WriteLine("Annual salary of person 2: ");
            int annualSalary2 = (hourlyRateToInt2 * hoursPerWeekToInt2) * 52;
            Console.WriteLine(annualSalary2);

            Console.WriteLine("Does person 1 make more than person 2?");
            bool makeMore = annualSalary > annualSalary2;
            Console.WriteLine(makeMore);

        }
    }
}

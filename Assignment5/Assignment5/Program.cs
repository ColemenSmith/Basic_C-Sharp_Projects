using System;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string inputAge = Console.ReadLine();
            int age = Int32.Parse(inputAge);

            Console.WriteLine("Have you ever had a DUI? (Answer true or false)");
            string inputDUI = Console.ReadLine();
            bool dui = Convert.ToBoolean(inputDUI);

            Console.WriteLine("How many speeding tickets do you have?");
            string inputTickets = Console.ReadLine();
            int tickets = Int32.Parse(inputTickets);

            Console.WriteLine("Qualified?");
            Console.WriteLine(age > 15 && dui == false && tickets < 3);

        }
    }
}

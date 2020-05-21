using System;

namespace Assignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();

            Console.WriteLine("Please enter the weight of your package.");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Please enter package width.");
                int packageWidth = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter package height.");
                int packageHeight = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter package length.");
                int packageLength = Convert.ToInt32(Console.ReadLine());

                if (packageWidth + packageHeight + packageLength > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    int costOfShip = (packageWidth * packageHeight * packageLength * packageWeight) / 100;
                    Console.WriteLine("Your total cost of shipping is $" + costOfShip);
                }
            }
        }
    }
}

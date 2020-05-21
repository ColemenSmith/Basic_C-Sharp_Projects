using System;

namespace Branching
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("What is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string result = favNum == 12 ? "You have an awesome favorite number!" : "You do not have a favorite number.";

            //int roomTemperature = 70;

            //Console.WriteLine("Hi, what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + " what is the room temperature?");
            //int currentTemp = Convert.ToInt32(Console.ReadLine());

            //if (currentTemp == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temp.");
            //}
            //else if (currentTemp > roomTemperature)
            //{
            //    Console.WriteLine("it is warmer than room temperature.");
            //}
            //else if (roomTemperature > currentTemp)
            //{
            //    Console.WriteLine("It is colder than room temp");
            //}
            //else
            //{
            //    Console.WriteLine("Uhh... something went wrong.");
            //}
            //int currentTemperature = 70;
            //int roomTemperature = 70;

            //string comparisonResult = currentTemperature == roomTemperature ? "It is room temp." : "It is not room temp.";
            //Console.WriteLine(comparisonResult);

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.Write("It is exactly room temperature.");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature.");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("Room temperature is warmer than the current temperature");
            //}
            //else
            //{
            //    Console.WriteLine("It is not exactly room temperature.");
            //}
        }
    }
}

using System;
using System.Collections.Generic;


namespace Assignment9
{
    class Program
    {
        static void Main()
        {

            string[] stringArray = { "Apples", "Pears", "Watermelon", "Peaches", "Grapes" };

            Console.WriteLine("Pick a number between 0 and 4");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num <= 4)
            {
                Console.WriteLine(stringArray[num]);
            }
            else
            {
                Console.WriteLine("That index doesn't exist. Please choose a number between 0 and 4.");
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(stringArray[num]);
                Console.ReadLine();
            }

            int[] intArray = { 1, 10, 100, 1000, 10000 };

            Console.WriteLine("Pick a number between 0 and 4.");
            int chosenNum = Convert.ToInt32(Console.ReadLine());

            if (chosenNum <= 4)
            {
                Console.WriteLine(intArray[chosenNum]);
            }
            else
            {
                Console.WriteLine("That index doesn't exist. Please choose a number between 0 and 4.");
                chosenNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(intArray[chosenNum]);
                Console.ReadLine();
            }

            List<string> stringList = new List<string>();
            stringList.Add("Broccoli");
            stringList.Add("Beets");
            stringList.Add("Cabbage");
            stringList.Add("Celery");
            stringList.Add("Onion");

            Console.WriteLine("Please enter a number between 0 and 4");
            int veggieNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(stringList[veggieNum]);

        }
    }
}

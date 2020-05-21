using System;

namespace Assignment7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Have you drank water recently?");
            string answer = Console.ReadLine();

            bool dehydrated = false;

            while (!dehydrated)
            {
                switch (answer)
                {
                    case "no":
                        Console.WriteLine("Go drink some water then try again");
                        Console.WriteLine("Have you drank water recently?");
                        answer = Console.ReadLine();
                        break;
                    case "yes":
                        Console.WriteLine("Nice work, it's good to stay hydrated.");
                        dehydrated = true;
                        break;
                }
            }

            Console.WriteLine("Have you eaten today?");
            string eaten = Console.ReadLine();

            bool starving = false;

            do
            {
                switch (eaten)
                {
                    case "no":
                        Console.WriteLine("Go eat and then try again.");
                        Console.WriteLine("Have you eaten today?");
                        eaten = Console.ReadLine();
                        break;
                    case "a little":
                        Console.WriteLine("You need to eat more than a little. Go eat some more then come back.");
                        Console.WriteLine("Have you eaten today?");
                        eaten = Console.ReadLine();
                        break;
                    case "yes":
                        Console.WriteLine("Good job. You're staying healthy");
                        starving = true;
                        break;
                }
            }
            while (!starving);

        }
    }
}

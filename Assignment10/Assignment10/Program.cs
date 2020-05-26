using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    class Program
    {
        static void Main()
        {
            string[] stringArray = { "Tomato", "Broccoli", "Cabbage", "Carrot" };

            foreach (string word in stringArray)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine("Enter a type of vegetable.");
            string veggie = Console.ReadLine();

            foreach (string word in stringArray)
            {
                Console.WriteLine(word + " " + veggie);
            }
            Console.ReadLine();

            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }

            for (int j = 0; j <= 6; j++)
            {
                Console.WriteLine(j);
            }

            string[] randoString = { "book", "movie", "cartoon", "documentary", "mockumentary" };

            Console.WriteLine("Enter some text to search the array.");
            string searchTerm = Console.ReadLine();


            for (int i = 0; i < randoString.Length; i++)
            {
                if (randoString[i].Contains(searchTerm))
                {
                    Console.WriteLine(Array.IndexOf(randoString, randoString[i]));
                }
                else
                {
                    Console.WriteLine("Your search term is not in the array.");
                }
            }

            string[] matchingString = { "pizza", "pizza", "sandwich", "lasagna", "spaghetti" };

            Console.WriteLine("Please enter text to search the array.");
            string srchTerm = Console.ReadLine();

            for (int i = 0; i < matchingString.Length; i++)
            {
                if (matchingString[i].Contains(srchTerm))
                {
                    Console.WriteLine(Array.IndexOf(matchingString, matchingString[i]));
                }
                else
                {
                    Console.WriteLine("Your text isn't in the list");
                }
            }

            List<string> lastString = new List<string> { "tree", "ocean", "mountain", "mountain", "reservoir" };

            List<string> duplicateCheck = new List<string> { };

            foreach(string thing in lastString)
            {

                if (!duplicateCheck.Contains(thing))
                {
                    Console.WriteLine("There are no duplicates.");
                }
                else if (duplicateCheck.Contains(thing))
                {
                    Console.WriteLine(thing + " appears in the list more than once.");
                }

                duplicateCheck.Add(thing);
            }

            Console.ReadLine();
        }
    }
}

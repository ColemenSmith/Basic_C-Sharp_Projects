using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            string number = Console.ReadLine();

            File.WriteAllText(@"C:\Users\smith\Desktop\Basic_C-Sharp_Projects\Assignment21\Log.txt", number);

            Console.WriteLine(File.ReadAllText(@"C:\Users\smith\Desktop\Basic_C-Sharp_Projects\Assignment21\Log.txt"));

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number: ");

            string choseNumber = Console.ReadLine();
            int choseNumberToInt = Int32.Parse(choseNumber);
            int multipliedByFifty = choseNumberToInt * 50;

            Console.WriteLine(choseNumber + " multiplied by 50 = " + multipliedByFifty);
            Console.ReadLine();

            Console.WriteLine("Please enter a whole number: ");

            string choseNumber2 = Console.ReadLine();
            int choseNumber2ToInt = Int32.Parse(choseNumber2);
            int addedTwentyFive = choseNumber2ToInt + 25;

            Console.WriteLine(choseNumber2 + " plus 25 = " + addedTwentyFive);
            Console.ReadLine();

            Console.WriteLine("Please enter a whole number: ");

            string choseNumber3 = Console.ReadLine();
            int choseNumber3ToInt = Int32.Parse(choseNumber3);
            double divideByTwentyFive = choseNumber3ToInt / 25.0;

            Console.WriteLine(choseNumber3 + " divided by 25 = " + divideByTwentyFive);
            Console.ReadLine();

            Console.WriteLine("Please enter a whole number: ");

            string choseNumber4 = Console.ReadLine();
            int choseNumber4ToInt = Int32.Parse(choseNumber4);
            bool isGreaterThan = choseNumber4ToInt > 50;

            Console.WriteLine("Is " + isGreaterThan + " greater than 50: " + isGreaterThan);
            Console.ReadLine();

            Console.WriteLine("Please enter a whole number: ");

            string choseNumber5 = Console.ReadLine();
            int choseNumber5ToInt = Int32.Parse(choseNumber5);
            int remainderOfNum = choseNumber5ToInt % 7;

            Console.WriteLine(choseNumber5 + " divided by 7 has a remainder of: " + remainderOfNum);
            Console.ReadLine();

        }
    }
}

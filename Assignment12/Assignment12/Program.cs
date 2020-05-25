using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number would you like to do operations on?");
            int num = Convert.ToInt32(Console.ReadLine());

            int timesThree = RandomNumber.timesBy3(num);
            Console.WriteLine(num + " multiplied by 3 = " + timesThree);
            Console.ReadLine();

            int bunchaStuff = RandomNumber.bunchaStuff(num);
            Console.WriteLine(num + " multiplied by 6 then 3 subtracted from it and then added to 10 = " + bunchaStuff);
            Console.ReadLine();

            int evenOrOdd = RandomNumber.evenOrOdd(num);
            
            Console.WriteLine("Now we will figure out if your number is even or odd. You entered " + num + " which after i put it into my magical equation returns " + evenOrOdd + " so it is: ");
            Console.ReadLine();
            if (evenOrOdd == 1)
            {
                Console.WriteLine("odd");
            }
            else
            {
                Console.WriteLine("even");
            }
            Console.ReadLine();
        }
    }
}

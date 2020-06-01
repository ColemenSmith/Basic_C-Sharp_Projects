using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment19
{
    struct Number
    {
        public decimal Amount;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Number value = new Number();
            value.Amount = 2.22m;
            Console.WriteLine(value.Amount);
            Console.ReadLine();
        }
    }
}

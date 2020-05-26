using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment13
{
    class RandomOperation
    {
        public static int multiplier(int num)
        {
            return num * 8;
        }

        public static decimal multiplier(decimal dec)
        {
            return dec * 8.32M;
        }

        public static int multiplier(string written)
        {
            int temp = Int32.Parse(written);
            return temp * 12;
        }
    }
}

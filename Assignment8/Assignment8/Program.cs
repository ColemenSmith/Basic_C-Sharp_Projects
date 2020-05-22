using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname = "Colemen ";
            string mname = "Jebbediah ";
            string lname = "Smith";

            Console.WriteLine(fname + mname + lname);

            string fullname = fname + mname + lname;
            string capitalname = fullname.ToUpper();

            Console.WriteLine(capitalname);

            StringBuilder sb = new StringBuilder();
            sb.Append("Hello, ");
            sb.Append("my name is Colemen ");
            sb.Append("and I enjoy coding in c#");


            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}

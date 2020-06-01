using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment23
{
    class practice
    {
        public string name;
        public int age;

        public practice() : this("John", 20)
        {
        }

        public practice(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            const string name = "Colemen";
            var age = 22;

            practice myself = new practice();

            myself.name = "Colemen";
        }
    }
}

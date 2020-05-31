using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.ID = 1234;
            employee.SayName();

            employee.Quit(employee);

            Employee employee2 = new Employee();
            employee2.FirstName = "Sample";
            employee2.LastName = "Student";
            employee2.ID = 1234;
            employee.SayName();

            Console.WriteLine(employee == employee2);
            Console.ReadLine();
        }
    }
}

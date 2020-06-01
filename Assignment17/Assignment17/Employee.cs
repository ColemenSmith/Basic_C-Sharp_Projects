using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17
{
    public class Employee : Person, IQuittable
    {
        public int ID { get; set; }

        public override void SayName()
        {
            Console.WriteLine("Fullname: " + FirstName + " " + LastName);
        }

        public void Quit(Employee employee)
        {
            Console.WriteLine("That's it! I quit!");
        }

        public static bool operator== (Employee employee, Employee employee2)
        {
            bool status = false;
            if (employee.ID == employee2.ID)
            {
                status = true;
            }
            return status;
        }

        public static bool operator!= (Employee employee, Employee employee2)
        {
            bool status = false;
            if (employee.ID == employee2.ID)
            {
                status = false;
            }
            return status;
        }
    }
}

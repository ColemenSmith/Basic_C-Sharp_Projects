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
            throw new NotImplementedException();
        }
    }
}

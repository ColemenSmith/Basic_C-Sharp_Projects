using System;
using System.Collections.Generic;


namespace Assignment17
{
    public class Employee<T> : Person//, IQuittable
    {
        private List<T> _thing = new List<T>();
        public List<T> thing { get { return _thing; } set { _thing = value; } }
        public int ID { get; set; }

        public override void SayName()
        {
            Console.WriteLine("Fullname: " + FirstName + " " + LastName);
        }

        public void Quit(Employee<T> employee)
        {
            Console.WriteLine("That's it! I quit!");
        }

        public static bool operator== (Employee<T> employee, Employee<T> employee2)
        {
            bool status = false;
            if (employee.ID == employee2.ID)
            {
                status = true;
            }
            return status;
        }

        public static bool operator!= (Employee<T> employee, Employee<T> employee2)
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

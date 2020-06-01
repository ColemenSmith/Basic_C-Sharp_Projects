using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment20
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }

        public override string ToString()
        {
            return "First Name: " + FirstName + "\nLast Name: " + LastName + "\nID: " + ID;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee() { FirstName = "Joe", LastName = "Smith", ID = 1 });
            employees.Add(new Employee() { FirstName = "Joe", LastName = "Thompson", ID = 2 });
            employees.Add(new Employee() { FirstName = "Steve", LastName = "Jobs", ID = 3 });
            employees.Add(new Employee() { FirstName = "Bob", LastName = "Segert", ID = 4 });
            employees.Add(new Employee() { FirstName = "Billy", LastName = "Joe", ID = 5 });
            employees.Add(new Employee() { FirstName = "Thomas", LastName = "Eldridge", ID = 6 });
            employees.Add(new Employee() { FirstName = "Jim", LastName = "John", ID = 7 });
            employees.Add(new Employee() { FirstName = "John", LastName = "Appleseed", ID = 8 });
            employees.Add(new Employee() { FirstName = "Jane", LastName = "Doe", ID = 9 });
            employees.Add(new Employee() { FirstName = "Lina", LastName = "Thompson", ID = 10 });

            //foreach(Employee name in employees)
            //{
            //    if (name.FirstName == "Joe")
            //    {
            //        Console.WriteLine(name);
            //    }
            //}

            var newList = employees.Where(x => x.ID > 5);
            foreach(var value in newList)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }
    }
}

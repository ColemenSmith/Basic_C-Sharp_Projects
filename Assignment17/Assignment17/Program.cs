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
            //Employee employee = new Employee();
            //employee.FirstName = "Sample";
            //employee.LastName = "Student";
            //employee.ID = 1234;
            //employee.SayName();

            //employee.Quit(employee);

            //Employee employee2 = new Employee();
            //employee2.FirstName = "Sample";
            //employee2.LastName = "Student";
            //employee2.ID = 1234;
            //employee.SayName();

            Employee<string> foodList = new Employee<string>();
            foodList.thing.Add("Pizza");
            foodList.thing.Add("Bagel");
            foodList.thing.Add("Sandwich");
            foodList.thing.Add("Lasagna");

            foreach(string food in foodList.thing)
            {
                Console.WriteLine(food);
            }

            Employee<int> numList = new Employee<int>();

            for (int i = 2; i < 8; i++)
            {
                numList.thing.Add(i + 2);
            }

            foreach (int num in numList.thing)
            {
                Console.WriteLine(num);
            }

            //Console.WriteLine(employee == employee2);
            Console.ReadLine();
        }
    }
}

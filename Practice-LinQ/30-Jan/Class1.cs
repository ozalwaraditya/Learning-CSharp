using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice_LinQ.Problem_3___Joins;

namespace Practice_LinQ._30_Jan
{
    public class Class1
    {

       public static void Main(string[] args)
        {
            List<Worker> employees = new List<Worker>();
            employees.Add(new Worker { Id = 1, Name = "Alice", Designation = "Developer", Salary = 60000 });
            employees.Add(new Worker { Id = 2, Name = "Bob", Designation = "Tester", Salary = 50000 });
            employees.Add(new Worker { Id = 3, Name = "Charlie", Designation = "Manager", Salary = 80000 });
            employees.Add(new Worker { Id = 4, Name = "Diana", Designation = "HR", Salary = 55000 });
            employees.Add(new Worker { Id = 5, Name = "Eve", Designation = "Developer", Salary = 62000 });

            Console.WriteLine(("Choose options : "));
            var option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1 :
                    break;
            }
            employees.Where( i=> ( i.Id > 2 && i.Designation == "Developer")  || i.Salary > 50000).ToList();
            foreach( var employee in employees)
            {
                Console.WriteLine(employee.Name);
            }
        }
    }



    class Worker
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required string Designation { get; set; }
        public required int Salary { get; set; }

        public void PrintEmployeeDetails()
        {
            Console.WriteLine("EmployeeId : " + Id + ", Name : " + Name + ", Designation : " + Designation + ", Salary : " + Salary);
        }
    }

}

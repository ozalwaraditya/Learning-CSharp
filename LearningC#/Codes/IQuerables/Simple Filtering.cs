using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC_.Codes
{
    public class IQuerable_Code
    {
        public static void main(string[] args)
        {
           var newEmployeeList = new[]
           {
               new Employee { Name = "Raj", Salary = 1000 },
               new Employee { Name = "Sam", Salary=5000}
           }.AsQueryable();

            newEmployeeList.Where(employee =>  employee.Salary > 100).Select( i=> i.Name ).ToList();

            foreach (var employee in newEmployeeList) { 
                Console.WriteLine(employee.Name);
            }
        }
    }

    public class Employee
    {
        public string Name { set; get; }
        public int Salary { get; set; }
    }

}

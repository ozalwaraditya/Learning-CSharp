using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    internal class _08_Jan_2025
    {
        public static void main(string[] args)
        {
            Employee e1 = new Employee { Id = 1, Name = "Aditya", Department = "Computer", Salary = 10 };
            Employee e2 = new Employee { Id = 2, Name = "Raj", Department = "Electronics", Salary = 20 };
            Employee e3 = new Employee { Id = 3, Name = "Ashu", Department = "Communication", Salary = 20 };


            List<Employee> employees = new List<Employee>() { e1, e2, e3 };


            Dictionary<int, Employee> dictionary = new Dictionary<int, Employee>();
            foreach (Employee e in employees)
            {
                dictionary[e.Id] = e;
            }

            var test = dictionary[1];

            Console.WriteLine($"Dictionary :  key:{1}, value:{test.Name} ");



            //=======================


            //Person p1 = new Person();
            //Person p2 = new Teacher();
            //Teacher p3 = new Teacher();

            //p1.currentRole();
            //p2.currentRole();
            //p3.currentRole();


            //=======================


            //List<string> list = new List<string>() { "aditya", "rajesh", "ozalwar" };
            //string singleString = string.Join(",", list);
            //Console.WriteLine(singleString);


            //=======================

            //Student student1 = new Student("Aditya");
            //Console.WriteLine("Student 1 Details : ");
            //student1.GetDetails();
            //Student student2 = new Student("Rambo", 201);
            //Console.WriteLine("Student 2 Details : ");
            //student2.GetDetails();

        }

        class Student
        {
            private string Name;
            private int roll;
            public Student(string name)
            {
                this.Name = name;
            }

            public Student(string name, int roll)
            {
                this.Name = name;
                this.roll = roll;
            }

            public void GetDetails()
            {
                Console.WriteLine($"Name : {Name} & Roll no : {roll}");
            }
        }


        class Person
        {
            //private string Name;

            public virtual void currentRole()
            {
                Console.WriteLine("Person");
            }
        }

        class Teacher : Person
        {
            public override void currentRole()
            {
                Console.WriteLine("Teacher");
            }
        }


        class Employee
        {
            public required string Name { get; set; }
            public int Id { get; set; }
            public int Salary { get; set; }
            public required string Department { get; set; }
        }

    }

}

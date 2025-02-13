using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagement.Methods
{
    //Method - Returns Dictionary{ Key:Designation, Value:List of employees belonging to that desgination }

    class Worker
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required string Designation { get; set; }
        public required int Salary { get; set; }

        //Constructor
        public void PrintEmployeeDetails()
        {
            Console.WriteLine("EmployeeId : " + Id + ", Name : " + Name + ", Designation : " + Designation + ", Salary : " + Salary);
        }
    }
    class Dictionary_Method
    {
        public static void main(string[] args)
        {
            List<Worker> employees = new List<Worker>();
            employees.Add(new Worker { Id = 1, Name = "Alice", Designation = "Developer", Salary = 60000 });
            employees.Add(new Worker { Id = 2, Name = "Bob", Designation = "Tester", Salary = 50000 });
            employees.Add(new Worker { Id = 3, Name = "Charlie", Designation = "Manager", Salary = 80000 });
            employees.Add(new Worker { Id = 4, Name = "Diana", Designation = "HR", Salary = 55000 });
            employees.Add(new Worker { Id = 5, Name = "Eve", Designation = "Developer", Salary = 62000 });
            employees.Add(new Worker { Id = 6, Name = "Frank", Designation = "Manager", Salary = 85000 });
            employees.Add(new Worker { Id = 7, Name = "Grace", Designation = "Tester", Salary = 52000 });
            employees.Add(new Worker { Id = 8, Name = "Hank", Designation = "Developer", Salary = 58000 });
            employees.Add(new Worker { Id = 9, Name = "Ivy", Designation = "HR", Salary = 54000 });
            employees.Add(new Worker { Id = 10, Name = "Jack", Designation = "Manager", Salary = 79000 });
            employees.Add(new Worker { Id = 11, Name = "Lily", Designation = "Developer", Salary = 65000 });
            employees.Add(new Worker { Id = 12, Name = "Mason", Designation = "Tester", Salary = 48000 });
            employees.Add(new Worker { Id = 13, Name = "Noah", Designation = "Manager", Salary = 90000 });
            employees.Add(new Worker { Id = 14, Name = "Olivia", Designation = "HR", Salary = 57000 });
            employees.Add(new Worker { Id = 15, Name = "Paul", Designation = "Developer", Salary = 67000 });
            employees.Add(new Worker { Id = 16, Name = "Quinn", Designation = "Tester", Salary = 53000 });

            Dictionary<string, List<Worker>> keyValuePairs = DictionaryListOptimized(ref employees);

            foreach (var element in keyValuePairs)
            {
                Console.WriteLine($"Designation: {element.Key}");
                Console.WriteLine("Employees:");
                foreach (Worker worker in element.Value)
                {
                    Console.WriteLine($"  - {worker.Name}");
                }
                Console.WriteLine();
            }
        }


        //Method - returning : Dictionary - key - designation , value - list of employee belonging to that group.

        public static Dictionary<string, List<Worker>> DictionaryList(ref List<Worker> workers)
        {
            if (workers == null || workers.Count == 0)
            {
                Console.WriteLine("No workers available.");
                return new Dictionary<string, List<Worker>>();
            }

            List<string> listOfDesignation = workers.Select(x => x.Designation).Distinct().ToList();

            Dictionary<string, List<Worker>> dict = new Dictionary<string, List<Worker>>();

            for (int i = 0; i < listOfDesignation.Count; i++)
            {
                dict.Add(listOfDesignation[i], GetWorkersByDesignation(listOfDesignation[i], workers));
            }
            return dict;
        }

        public static List<Worker> GetWorkersByDesignation(string designation, List<Worker> workers)
        {
            return workers
                .Where(i => i.Designation == designation)
                .ToList();
        }


        //Optimized
        public static Dictionary<string, List<Worker>> DictionaryListOptimized(ref List<Worker> workers)
        {
            // Proceed with grouping
            var groupByList = workers.GroupBy(i => i.Designation);
            Dictionary<string, List<Worker>> dict = new Dictionary<string, List<Worker>>();

            foreach (var group in groupByList)
            {
                dict.Add(group.Key, group.ToList());
            }

            return dict;
        }
    }
}

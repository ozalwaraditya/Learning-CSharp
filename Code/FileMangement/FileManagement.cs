using System;
using System.Collections.Generic;
using System.IO;

namespace FileManagement.FileMangement
{
    class Program
    {
        public static void main(string[] args)
        {
            List<Worker> employees = new List<Worker>
            {
                new Worker { Id = 1, Name = "Alice", Designation = "Developer", Salary = 60000 },
                new Worker { Id = 2, Name = "Bob", Designation = "Tester", Salary = 50000 },
                new Worker { Id = 3, Name = "Charlie", Designation = "Manager", Salary = 80000 },
                new Worker { Id = 4, Name = "Diana", Designation = "HR", Salary = 55000 },
                new Worker { Id = 5, Name = "Eve", Designation = "Developer", Salary = 62000 }
            };

            Console.Write("Enter the number of employees you want to add: ");
            if (!int.TryParse(Console.ReadLine(), out int numberOfEmployee))
            {
                Console.WriteLine("Invalid input. Exiting program.");
                return;
            }

            for (int i = 0; i < numberOfEmployee; i++)
            {
                Console.WriteLine($"\nEnter Employee {i + 1} details.");
                Console.Write("Name: ");
                string name = Console.ReadLine()?.Trim() ?? "";
                Console.Write("Id: ");
                if (!int.TryParse(Console.ReadLine(), out int id))
                {
                    Console.WriteLine("Invalid ID. Skipping employee.");
                    continue;
                }
                Console.Write("Designation: ");
                string designation = Console.ReadLine()?.Trim() ?? "";
                Console.Write("Salary: ");
                if (!int.TryParse(Console.ReadLine(), out int salary))
                {
                    Console.WriteLine("Invalid salary. Skipping employee.");
                    continue;
                }

                employees.Add(new Worker { Id = id, Name = name, Designation = designation, Salary = salary });
            }

            string filePath = "C:\\Users\\adityao\\source\\repos\\LearningC#\\FileManagement\\FileManagement.csv";
            WriteToCSV(filePath, employees);

            Console.WriteLine("\nSheet has been successfully updated.\n");
            ReadFromCSV(filePath);
        }

        public static void ReadFromCSV(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found.");
                return;
            }

            using (var reader = new StreamReader(filePath))
            {
                bool header = true;
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (header)
                    {
                        header = false;
                        continue;
                    }

                    var cell = line.Split(',');
                    if (cell.Length < 4) continue;

                    if (int.TryParse(cell[0], out int id) && int.TryParse(cell[3], out int salary))
                    {
                        var employee = new Worker()
                        {
                            Id = id,
                            Name = cell[1].Trim(),
                            Designation = cell[2].Trim(),
                            Salary = salary
                        };
                        employee.PrintEmployeeDetails();
                    }
                }
            }
        }

        public static void WriteToCSV(string filePath, List<Worker> employees)
        {
            using (var writer = new StreamWriter(filePath))
            {
                writer.WriteLine("EmployeeId,Name,Designation,Salary");
                foreach (var employee in employees)
                {
                    writer.WriteLine($"{employee.Id},{employee.Name},{employee.Designation},{employee.Salary}");
                }
            }
        }
    }

    class Worker
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Designation { get; set; } = string.Empty;
        public int Salary { get; set; }

        public void PrintEmployeeDetails()
        {
            Console.WriteLine($"EmployeeId: {Id}, Name: {Name}, Designation: {Designation}, Salary: {Salary}");
        }
    }
}

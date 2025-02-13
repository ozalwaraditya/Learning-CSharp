namespace FileManagement.FileMangement
{
    class Program
    {
        public static void main(string[] args)
        {

            List<Worker> employees = new List<Worker>();
            employees.Add(new Worker { Id = 1, Name = "Alice", Designation = "Developer", Salary = 60000 });
            employees.Add(new Worker { Id = 2, Name = "Bob", Designation = "Tester", Salary = 50000 });
            employees.Add(new Worker { Id = 3, Name = "Charlie", Designation = "Manager", Salary = 80000 });
            employees.Add(new Worker { Id = 4, Name = "Diana", Designation = "HR", Salary = 55000 });
            employees.Add(new Worker { Id = 5, Name = "Eve", Designation = "Developer", Salary = 62000 });


            Console.WriteLine("Enter the number of employees you want to add : ");
            var numberOfEmployee = int.Parse(Console.ReadLine());



            for (int i = 0; i < numberOfEmployee; i++)
            {
                Console.WriteLine("\nEnter Employee " + (i + 1) + " details.");
                Console.Write("Name : ");
                var name = Console.ReadLine();
                Console.Write("Id : ");
                var id = int.Parse(Console.ReadLine());
                Console.Write("Designation : ");
                var designation = Console.ReadLine();
                Console.Write("Salary : ");
                var salary = int.Parse(Console.ReadLine());

                employees.Add(new Worker { Id = id, Name = name, Designation = designation, Salary = salary });

            }

            string filePath = "C:\\Users\\adityao\\source\\repos\\LearningC#\\FileManagement\\FileManagement.csv";

            WriteToCSV(filePath, employees);

            Console.WriteLine("\n Sheet has successfully updated\n");

            ReadFromCSV(filePath);

        }

        public static void ReadFromCSV(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            {
                string line;
                bool header = true;
                while ((line = reader.ReadLine()) != null)
                {
                    if (header)
                    {
                        header = false;
                        continue;
                    }

                    var cell = line.Split(',');

                    var employee = new Worker()
                    {
                        Id = int.Parse(cell[0]),
                        Name = cell[1],
                        Designation = cell[2],
                        Salary = int.Parse(cell[3])
                    };

                    employee.PrintEmployeeDetails();

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
                    writer.WriteLine($"{employee.Id}, {employee.Name}, {employee.Designation}, {employee.Salary}");
                }
            }
        }

    }
}
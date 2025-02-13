using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagement.Practicing_LinQ
{
    public class StudentListHandling
    {
        public static void main(string[] args)
        {
            Random random = new Random();

            string[] indianNames = {"Aditya", "Aarav", "Ishita", "Ananya", "Raj", "Riya", "Aryan", "Neha", "Siddharth","Kavya", "Manish", "Priya", "Suresh", "Anil", "Pooja"};

            List<Student> students = new List<Student>();

            foreach (string name in indianNames){
                students.Add(new Student{ Name = name, English = random.Next(1, 11), Math = random.Next(1, 11), Science = random.Next(1, 11)});
            }

            foreach (var student in students){
                Console.WriteLine($"Name: {student.Name}, English: {student.English}, Math: {student.Math}, Science: {student.Science}");
            }

            //Using methods
            
            //var averages = AverageScoreList(students);
            //foreach (var avg in averages)
            //{
            //    Console.WriteLine($"{avg}");
            //}
            int i = 1;
            var rankList = RankList(students);
            foreach(var rankers in rankList)
            {
                Console.WriteLine($"Rank {(i)} : {rankers.Name}");
                i++;
            }
        }

        public static List<double> AverageScoreList(List<Student> students)
        {
            return students.Select(i => (i.English + i.Math + i.Science) /3.0).ToList();
        }

        public static List<Student> HighScores(List<Student> students)
        {
            return students.Where(i => i.English >= 9 &&  i.Science >= 9 && i.Math >= 9).ToList();
        }

        public static List<Student> RankList(List<Student> students) {
            return students.OrderByDescending( i=> i.English + i.Science + i.Math).ToList();
        }

    }
}

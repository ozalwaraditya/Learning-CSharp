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

           
            int i = 1;
            var rankList = RankList(students);
            var gradeWiseList = GradeBasedStudents(students);
            //foreach(var rankers in rankList)
            //{
            //    Console.WriteLine($"Rank {(i)} : {rankers.Name}");
            //    i++;
            //}

            //foreach (var group in gradeWiseList.OrderBy(i=>i.Key)) {
            //    Console.Write($"{group.Key} :- ");
            //    foreach(var student in group.Value)
            //    {
            //        Console.Write($"{student.Name}, ");
            //    }
            //    Console.WriteLine();
            //}

            var dict = GetBestSubjectSingle(students);

            foreach (var element in dict)
            {
                Console.WriteLine($"{element.Key} : " + $" {element.Value}");
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

        public static Dictionary<string, List<Student>> GradeBasedStudents(List<Student> students)
        {
            Dictionary<string, List<Student>> dict =new Dictionary<string, List<Student>>();
            var groupByGradeList = students.GroupBy( i => (i.English + i.Math + i.Science) >= 20 ? "A" : (i.English + i.Math + i.Science) >= 15 ? "B" : "C");
            foreach(var group in groupByGradeList)
            {
                dict.Add(group.Key, group.ToList());
            }
            return dict;
        }


        //Only single highest subject
        public static Dictionary<string, string> GetBestSubjectSingle(List<Student> students) {
            var nameList = students.Select(i => i.Name).ToList();
            var bestSubject = students.Select(i => ((i.English >= i.Math) && (i.English >= i.Science) ? "English" : ((i.Math >= i.Science) ? "Math" : "Science"))).ToList();

            Dictionary<string, string> dict = new Dictionary<string, string>();
            int i = 0;

            foreach (var name in nameList)
            {
                dict.Add(name, bestSubject[i]);
                i++;
            }

            return dict;

            //Optimized
            return students.ToDictionary(
                    i =>i.Name,
                    i => (i.English >= i.Math) && (i.English >= i.Science) ? "English" : ((i.Math >= i.Science) ? "Math" : "Science")
                );
        }

    }
}
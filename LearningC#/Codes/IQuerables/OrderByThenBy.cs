using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC_.Codes.IQuerables
{
    public class OrderByThenBy
    {
        public static void main(string[] args)
        {
            var studentList = new List<Student>()
            {
                new Student{ Name = "Aditya", Roll = 15, Class = 5},
                new Student{ Name = "Ashutosh", Roll = 20, Class = 6},
                new Student{ Name = "Martand", Roll = 25, Class = 7},
                new Student{ Name = "Tanmay", Roll = 30, Class = 8},
            }.AsQueryable();


            studentList.OrderByDescending(s => s.Name)
                .ThenBy(s => s.Roll)
                .ToList();

            foreach (var student in studentList) {
                Console.WriteLine(student.Name + " " + student.Roll);
            }
        }
    }

    public class Student
    {
        public string Name { get; set;}
        public int Roll { get; set;}
        public int Class { get; set;}
    }
}

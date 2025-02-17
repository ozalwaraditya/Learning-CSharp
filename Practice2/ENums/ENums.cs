using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Practice2.ENums;

namespace Practice2.ENums
{
    public enum Gender
    {
        Male,
        Female =  33,
        Unknown = 2
    }

    public class ENums
    {
        public static void Main(string[] args)
        {
            //----Now getting the values and names of the enums

            int[] values = (int[])Enum.GetValues(typeof(Gender));
            foreach (int value in values)
            {
                Console.WriteLine(value);
            }


            //----Printing the enums with the help of method 

            //Student[] students = new Student[3];
            //students[0] = new Student { Name = "Aditya", Gender = Gender.Male };
            //students[1] = new Student { Name = "Shrutika", Gender = Gender.Female };
            //students[2] = new Student { Name = "Random", Gender = Gender.Unknown };


            //foreach (Student student in students) {
            //    Console.WriteLine("Name : {0},  Gender : {1}", student.Name, GetGender(student.Gender));
            //}
        }
        public static string GetGender(Gender gender)
        {
            switch (gender)
            {
                case Gender.Male: return "Male";
                case Gender.Female: return "Female";
                case Gender.Unknown: return "Unknown";
                default: return "Invalid Information";
            }
        }
    }      


    public class Student
    {
        public string Name { get; set; }
        public Gender  Gender { get; set; }
    }
}

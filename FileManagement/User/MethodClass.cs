using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningC_.User;

namespace FileManagement.User
{
    public class MethodClass
    {
        public static void main(string[] args)
        {
            List<LearningC_.User.User> handler = new List<LearningC_.User.User>();

            handler.Add(new LearningC_.User.User("aditya", "password", "aditya@gmail.com", 001));
            handler.Add(new LearningC_.User.User("raj", "pass02", "raj@gmail.com", 002));
            handler.Add(new LearningC_.User.User("user", "pass3", "user@gmail.com", 003));

            var filteredList = FilterList("", "", handler);

            foreach (var item in filteredList) { 
                Console.WriteLine(item.Username + " " + item.Email);
            }

            WriteOnCsv(filteredList);
            Console.WriteLine("Sheet updated!!");

        }

        //Original-Code
        public static List<LearningC_.User.User> FilterList(string name, string email, List<LearningC_.User.User> handler) {
            List<LearningC_.User.User> filteredList = new List<LearningC_.User.User>();
            //if (name == null)
            //{
            //    return handler.Where(i => i.Email.Contains(email)).ToList();
            //}
            //else
            //{
            //    if (email == null) {
            //        return handler.Where(i => i.Username.Contains(name)).ToList(); 
            //    }
            //    return handler.Where(i => i.Username.Contains(name) && i.Email.Contains(email)).ToList();
            //}

            return handler.Where(i => (!string.IsNullOrEmpty(name) || i.Username.Contains(name)) && (!string.IsNullOrEmpty(email) || i.Email.Contains(email))).ToList();
        }

        public static void WriteOnCsv (List<LearningC_.User.User> list)
        {
            string filePath = "C:\\Users\\adityao\\source\\repos\\LearningC#\\FileManagement\\User\\FileManagement.csv";

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Id,UserName,Email");
                    foreach (var item in list)
                    {
                        writer.WriteLine($"{item.Id},{item.Username},{item.Email}");
                    }
            }
            // Alternate method is there.
        }
    }
}
//Delayed and Differed Execution.
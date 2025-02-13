using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC_.Collections.Generic_Methods
{
    internal class Generic_Methods
    {
        public static void main(string[] args)
        {
            /*====================  Generic Methods  ==================== */

            // Initialize the list
            List<string> myList = new List<string>
            {
                "This is my Dog",
                "Name of my Dog is Robin",
                "This is my Cat",
                "Name of the cat is Mewmew"
            };

            // Use LINQ to filter items containing "my"
            var res = myList.Where(l => l.Contains("my"));

            var completeInformation = from item in myList
                                      select item;

            Console.Write("Write complete information : ");
            foreach (var item in completeInformation)
            {
                Console.WriteLine(item);
            }


            Console.Write("Normal List:");

            // Iterate over the results and print them
            foreach (var q in res)
            {
                Console.WriteLine(q);
            }

            ///*Generalized methods which can be used apart constrains of datatypes. */


            LearningGenericMethods<int>(123);
            LearningGenericMethods<string>("aditya");


            //Another Example

            string s1 = "aditya";
            string s2 = "ozalwar";
            GenericSwappingItems<string>(ref s1, ref s2);

            Console.WriteLine("String 1 : " + s1 + ", String 2 : " + s2);


            int i1 = 10;
            int i2 = 20;

            GenericSwappingItems<int>(ref i1, ref i2);

            Console.WriteLine("Integer 1 : " + i1 + ", Integer 2 : " + i2);

        }

        public static void LearningGenericMethods<T>(T i)
        {
            Console.WriteLine($"{typeof(T)} : value is {i}");
        }

        public static void GenericSwappingItems<T>(ref T item1, ref T item2)
        {
            T temp = item1;
            item1 = item2;
            item2 = temp;
        }

    }

}

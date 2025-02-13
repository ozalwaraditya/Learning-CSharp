using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC_.Codes
{
    public class IEnumerable_Code
    {
        public static void main(string[] args)
        {

            IEnumerable<int> integers = new List<int>() { 1, 2, 3, 44, 53, 26, 27, 83, 9, 65, 100 };


            IEnumerable<string> strings = new List<string>() { "aditya", "adi", "ozalwar", "building" };

            IEnumerable<string> list = SubStringFinding(strings, "adi");

            Console.WriteLine("Number of element greater than 50 : " + CountingNumberOfElements(integers, 50));


            //Intermidiate

            IEnumerable<Product> products = new List<Product>() {
                new Product() {Name = "Pen", Price = 20, Category = "Stationary" },
                new Product() {Name = "Pulav", Price = 100, Category = "Food" },
                new Product() {Name = "LipsStick", Price = 200, Category = "Beauty" },
                new Product() {Name = "Book", Price = 50, Category = "Stationary" }
            };

            IEnumerable<Product> simpleProducts = ProductWithinRange(products, 10, 70);


            Console.WriteLine($"What is maximum value : {MaxOutofList(products)}");

            IEnumerable<string> stringList = new List<string>() { "aditya", "ashutosh", "amarjit", "vinayak", "akash", "ram" };

            var desiredList = ListToUpperCase(stringList);

            Console.Write("Upper-List : ");
            foreach(var item in desiredList)
            {
                Console.Write(item + " ");
            }
        }


        //Beginner-Level

        public static IEnumerable<int> EvenNumber(IEnumerable<int> numbers)
        {
            return numbers.Where(v => v % 2 == 0);
        }

        public static IEnumerable<string> SubStringFinding(IEnumerable<string> list, string substring)
        {
            return list.Where(v => v.Contains(substring));
        }

        public static int CountingNumberOfElements(IEnumerable<int> numbers, int threeshold)
        {
            IEnumerable<int> listOfNumbers = numbers.Where(i => i >= threeshold);

            return listOfNumbers.Count();
        }

        public static IEnumerable<int> ListGreaterThan(IEnumerable<int> list)
        {
            return list.Where(i => i > 10);
        }

        //Intermediate

        public static IEnumerable<Product> ProductWithinRange(IEnumerable<Product> products, int lowerlimit, int upperlimit)
        {
            IEnumerable<Product> finalList = products.Where(v => v.Price < upperlimit && v.Price >= lowerlimit);
            return finalList;

        }

        public static int MaxOutofList(IEnumerable<Product> products)
        {
            int max = int.MinValue;
            foreach (Product product in products)
            {
                if (product.Price > max) max = product.Price;
            }

            return max;
        }

        public static IEnumerable<string> ListToUpperCase(IEnumerable<string> list)
        {
            return list.Where(i => i.Length >= 4).Select(word => word.ToUpper());
        }



        public class Product
        {
            public string Name { get; set; }
            public int Price { get; set; }
            public string Category { get; set; }
        }
    }
}

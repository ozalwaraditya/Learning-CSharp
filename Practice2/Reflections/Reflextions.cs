using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Reflections
{
    // 21-Feb-2025
    public class Reflextions
    {
        public static void Main(string[] args)
        {
            Type type = typeof(Customer);

            var properties = type.GetProperties();
            foreach (var item in properties)
            {
                Console.WriteLine(item.PropertyType.Name + " " + item.Name);
            }
        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Customer()
        {
            Console.WriteLine("This is constructor");
        }
     }
}

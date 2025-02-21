using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Delegates
{
    public class Deleg
    {
        public delegate void HelloFunctionDelegate(string message);

        public static void main(string[] args)
        {
            HelloFunctionDelegate del = Hello;

            del("Aditya");
        }
        public static void Hello(string Name)
        {
            Console.WriteLine("Hello " + Name);
        }
        
    }
}

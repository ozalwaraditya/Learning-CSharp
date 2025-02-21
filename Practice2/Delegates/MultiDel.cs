using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Delegates
{

    //In this one delegate is created - containing same parameter in it.
    //And adding the functions one after another
    // OUTPUT -> It calls the function as FIFO.


    public delegate void multiDelegate(string message);

    public class MultiDel
    {
        public static void funct1(string message)
        {
            Console.WriteLine("Function 1:" + message);
        }
        public static void funct2(string message)
        {
            Console.WriteLine("Function 2:" + message);
        }

        public static void main(string[] args)
        {
            multiDelegate multidel = funct1;
            multidel = multidel + funct2;
            multidel("aditya");
        }
    }
}

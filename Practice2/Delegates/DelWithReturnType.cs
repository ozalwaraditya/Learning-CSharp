using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Delegates
{

    public delegate int MathOPT(int a, int b);
    public class DelWithReturnType
    {
        public static int Add(int a, int b) { return a + b; }
        public static int Multiply(int a, int b) { return a * b; }

        public static void main(string[] args)
        {
            MathOPT mathOperations = Add;
            var answer  = mathOperations(4, 2);

            Console.WriteLine(answer);

            mathOperations  = Multiply;
            answer = mathOperations(12,13);
            Console.WriteLine(answer);

        }
    }
}

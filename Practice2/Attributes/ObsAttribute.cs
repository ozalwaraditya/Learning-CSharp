using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;

namespace Practice2.Attributes
{
    public class ObsAttribute
    {
        public static void main(string[] args)
        {
            int sumation = Calculator.Add(12, 12);



        }
    }
    public class Calculator
    {
        [Obsolete("Use new functions Add(List<int>)")]
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Add(List<int> a)
        {
            int sum = 0;
            foreach (int i in a)
            {
                sum += i;
            }
            return sum;
        }
    }
}

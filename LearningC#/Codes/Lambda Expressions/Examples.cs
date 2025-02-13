using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC_.Codes.Lambda_Expressions
{
    public class Examples
    {
        public static void main(string[] args)
        {
            Func<int, int> square = (x) => x * x;

            Action hello = () => { Console.WriteLine("Hello Lamda Functionssss"); };

            hello();


        }
    }
}

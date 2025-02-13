using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC_.Basics
{
    public class Basics
    {
        public static void main(string[] args)
        {
            /*=====  Loop  ======*/

            // To print the thing contibuously

            int variable = 0;
            Console.Write("Enter the number of which you want table : ");
            var number = Console.ReadLine();
            int num = Convert.ToInt32(number);


            ////For-loop example
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(num + " X " + (i + 1) + " = " + (num * (i + 1)));
            }


            //-------------  For each statement implementation.


            Console.Write("Enter the size of the array: ");
            var s = Console.ReadLine();
            int size = Convert.ToInt32(s);

            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter the element for position " + i + ": ");
                var element = Console.ReadLine();
                array[i] = Convert.ToInt32(element);
            }



            //Console.WriteLine("\nThe entered array is:");

            foreach (var element in array)
            {
                Console.Write(element + " ");
            }



            //-------------  While - loop implementation.

            Console.WriteLine("Enter the number of times the line should be printed : ");
            var t = Console.ReadLine();
            var size2 = Convert.ToInt32(t);
            while (size2 > 0)
            {
                Console.WriteLine(size);
                size2--;
            }


            //-------------  do while - loop implementation.


            int number2;
            do
            {
                Console.Write("Enter a positive number: ");
                var input2 = Console.ReadLine();
                number2 = Convert.ToInt32(input2);

                if (number2 <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive number.");
                }
            }
            while (number2 <= 0);

            Console.WriteLine("You entered a valid number: " + number2);


            /*====================  Variables  =============================*/
            //Types of variables = int, float, double, bool, string, char

            // int - 4 bytes
            // long - 8 bytes
            // float & double
            // bool - 1 
            // char - 2 bytes
            // string - 4 bytes

            // const - once the variable is declared with const it is immutable.
            // var - datatype of the variable is set accordingly.
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC_.Collections.Arrays
{
    public class Arrays
    {
        public static void main(string[] args)
        {

            Console.Write("Enter the size of the array : ");
            var siz = Console.ReadLine();
            var size = int.Parse(siz);
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter the {(i + 1)}th element of the array. ");
                var ele = Console.ReadLine();
                var element = int.Parse(ele);
                array[i] = element;
            }

            Console.WriteLine("Actual Array : ");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{array[i]} ");
            }


            Console.WriteLine();
            Console.WriteLine("Reverse Array : ");
            for (int i = size - 1; i >= 0; i--)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace LearningC_.Recurrsion
{
    public class Recurrsion
    {
        public static void main(string[] args)
        {
            //var answer = FindNthTriangleSum(2);
            //Console.WriteLine(answer);

            //Console.Write("Enter a number : ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int[] array = { 2, 20, 180, 1080 };
            //var factorial = BinarySearch(array,10, 0, array.Length - 1);
            //var sum = CheckAscOrder(array);

            //if (sum)
            //{
            //    Console.WriteLine("Sorted");
            //}
            //else
            //{
            //    Console.WriteLine("Not Sorted");
            //}


            //var name = "aditya";
            //var length = StringLength(name);
            //Console.WriteLine(length);

            //Console.WriteLine(sum);

            //Console.Write("Enter base : ");
            //var baseNum = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter power : ");
            //var powerNum = Convert.ToInt32(Console.ReadLine());
            //var answer = powerOf(baseNum, powerNum);
            //Console.WriteLine(answer);

            //Console.Write("Enter a string : ");
            //string str = Console.ReadLine();

            //var rev = ReverseString(str);
            //Console.WriteLine(rev);

            int[] nums = { 1, 2, 3 };
            List<List<int>> result = new List<List<int>>();

            findAllSubsets(nums, new List<int>(), 0, result);

            Console.WriteLine("All Subsets:");
            foreach (var subset in result)
            {
                Console.WriteLine("[" + string.Join(", ", subset) + "]");
            }

        }


        //Factorial of given number.
        public static int Factorial(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            return number * Factorial(number - 1);
        }

        //Find nth number in Fibbonacci series
        public static int fibbonacci(int number)
        {
            if (number <= 0)
            {
                return 0;
            }
            if (number == 1)
            {
                return 1;
            }

            return fibbonacci(number - 1) + fibbonacci(number - 2);
        }

        //Power of number
        public static int powerOf(int baseNum, int powerNum)
        {
            if (powerNum == 1 || powerNum == 0)
            {
                return baseNum;
            }
            return (baseNum * powerOf(baseNum, powerNum - 1));
        }

        //Sum of n natural numbers
        public static int sumOfNaturalNumbers(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            return sumOfNaturalNumbers(number - 1) + number;
        }

        //Reverse of string.
        public static string ReverseString(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return "";
            }
            return str[str.Length - 1] + ReverseString(str.Substring(0, str.Length - 1));
        }

        //Sumation of digits
        public static int SumOfDigit(int number)
        {
            if (number == 0)
            {
                return 0;
            }

            return (number % 10 + SumOfDigit(number / 10));
        }


        //Binary Search 
        public static int BinarySearch(int[] array, int number, int start, int end)
        {
            if (start > end)
            {
                return -1;
            }

            int mid = start + (end - start) / 2;

            if (number == array[mid])
            {
                return mid;
            }

            if (array[mid] < number)
            {
                return BinarySearch(array, number, mid + 1, end);
            }
            else
            {
                return BinarySearch(array, number, start, mid - 1);
            }
        }

        //Summation of even number in an array
        public static int SumOfEvenInArray(int[] arr)
        {
            if (arr.Length == 0)
            {
                return 0;
            }
            int lastElementIndex = arr.Length - 1;

            return ((arr[lastElementIndex] % 2 == 0) ? arr[lastElementIndex] : 0) + SumOfEvenInArray(arr.Take(lastElementIndex).ToArray());
        }

        //Check array is in ascending order or not -- [Checking from backwards]
        public static bool CheckAscOrder(int[] arr)
        {
            //array with zero or single element
            if (arr.Length == 1 || arr.Length == 0)
            {
                return true;
            }

            //checking the last element is greater than last element or not
            if (arr[arr.Length - 1] < arr[arr.Length - 2])
            {
                return false;
            }

            //sends sub array
            return CheckAscOrder(arr.Take(arr.Length - 1).ToArray());

        }

        //Returns string length
        public static int StringLength(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            return 1 + StringLength(str.Substring(1));
        }


        //Sumation of the nth triangle required nodes
        public static int FindNthTriangleSum(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            return number + FindNthTriangleSum(number - 1);
        }



     
        static void findAllSubsets(int[] arr, List<int> current, int index, List<List<int>> result)
        {
            result.Add(new List<int>(current));

            for (int i = index; i < arr.Length; i++)
            {
                current.Add(arr[i]);

                findAllSubsets(arr, current, i + 1, result);

                current.RemoveAt(current.Count - 1); // back tracked
            }
        }
    }
}
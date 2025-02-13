using System;
using System.Collections.Generic;

namespace LearningC_.Recurrsion.Backtracking
{
    public class BackTracking
    {
        public static void main(string[] args)
        {
            List<List<int>> result = new List<List<int>>();
            List<int> current = new List<int>();
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int k = 3;

            GetAllPairForKElement(arr, current, 0, k, result);

            foreach (var array in result)
            {
                foreach (var element in array)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine(); 
            }

        }

        public static void GetAllPairForKElement(int[] arr, List<int> current, int index, int k, List<List<int>> result)
        {
            if (current.Count == k)
            {
                result.Add(current);
                return;
            }

            for (int i = index; i < arr.Length; i++)
            {
                current.Add(arr[i]);
                GetAllPairForKElement(arr, current, i + 1, k, result);
                current.RemoveAt(current.Count - 1);  // Taking back
            }
        }
    }
}

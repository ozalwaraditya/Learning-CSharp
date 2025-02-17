using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;

namespace LearningC_.Recurrsion.Backtracking
{
    public class BackTracking
    {
        public static void main(string[] args)
        {

            //List<List<int>> result = new List<List<int>>();
            //List<int> current = new List<int>();
            //int[] arr = { 1, 2, 3, 3 };
            //int k = 3;



            //-----------1 

            int[] arr = { 1, 2, 2 };
            Array.Sort(arr); // Sorting ensures duplicates are adjacent
            List<List<int>> result = new List<List<int>>();
            List<int> current = new List<int>();

            GetAllSubsetsInArrayWithDuplicate(arr, current, 0, result);




            foreach (var array in result)
            {
                foreach (var element in array)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }

        }

        // Get all possible subset of k element from an array
        public static void GetAllPairForKElement(int[] arr, List<int> current, int index, int k, List<List<int>> result)
        {
            if (current.Count == k)
            {
                result.Add(new List<int>(current));   //
                return;
            }

            for (int i = index; i < arr.Length; i++)
            {
                current.Add(arr[i]);
                GetAllPairForKElement(arr, current, i + 1, k, result);
                current.RemoveAt(current.Count - 1);  // Taking back
            }
        }


        public static void GetAllSubsets(int[] array, List<int> current, int index, List<List<int>> result)
        {
            result.Add(new List<int>(current));

            for (int i = index; i < array.Length; i++)
            {
                current.Add(array[i]);
                GetAllSubsets(array, current, i + 1, result);
                current.RemoveAt(current.Count - 1);
            }
        }

        public static void GetAllSubsetsInArrayWithDuplicate(int[] array, List<int> current, int index, List<List<int>> result)
        {
            result.Add(new List<int>(current)); 

            for (int i = index; i < array.Length; i++)
            {
                while (i > index && i < array.Length && array[i] == array[i - 1])
                {
                    i++;
                }

                if (i >= array.Length)
                    break;

                current.Add(array[i]);
                GetAllSubsetsInArrayWithDuplicate(array, current, i + 1, result);
                current.RemoveAt(current.Count - 1); 
            }
        }
    }
}

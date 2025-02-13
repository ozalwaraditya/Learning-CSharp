using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC_.Collections.Dictonaries
{
    internal class Dictionary
    {
        public static void main(string[] args) {

            /*   Dictionary - Unordered , key-value pair stored.  */

            Dictionary<int, string> map = new Dictionary<int, string>();

            map.Add(1, "Aditya");
            map.Add(2, "Martand");
            map.Add(3, "Deepak");

            foreach (var key in map.Keys)
            {
                Console.WriteLine(map[key]);
            }

        }
    }
}

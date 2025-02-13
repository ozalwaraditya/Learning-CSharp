using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC_.Collections.List
{
    public class List
    {
        public static void main(string[] args)
        {

            /*  List - Ordered, allows duplicate */

            List<int> list = new List<int>();
            list.Add(1);
            list.Add(22);
            list.Add(3);
            list.Add(4);

            list.Reverse();

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC_.LinkedList
{
    public class Class1
    {
        public static void main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.AddFirst(1);
            linkedList.AddFirst(2);
            linkedList.AddLast(5);
            linkedList.AddFirst(4);
            linkedList.AddFirst(3);

            LinkedListNode<int> node = linkedList.Find(4);

            if (node != null) {
                linkedList.AddBefore(node, 101);
            }

          

            linkedList.AddLast(10);
            linkedList.AddLast(20);
            linkedList.AddLast(30);
            linkedList.AddLast(40);
            linkedList.AddLast(50);
            linkedList.AddLast(60);

          

            // Removing the first element using
            // Remove(LinkedListNode)
            linkedList.Remove(linkedList.First);
          

            // Removing a specific element (20) using Remove(T)
            linkedList.Remove(101);
            linkedList.Remove(2);


            foreach (int i in linkedList)
            {
                Console.WriteLine(i);
            }
        }
    }
}

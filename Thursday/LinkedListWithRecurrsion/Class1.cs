using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Thursday.LinkedListWithRecurrsion
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
    public class Class1
    {
        public static void Main(string[] args)
        {
            LL ll = new LL();
            ll.AddNewNode(12);
            ll.AddNewNode(13);
            ll.AddNewNode(14);
            ll.AddNewNode(15);

            //ll.revLL(null, ll.head);
            var head = ll.ReverseList(ll.head);
            ll.Print();

        }
    }

    public class LL
    {
        public Node head;
        public int length;


        public void revLL(Node prev, Node currentNode)
        {
            if (currentNode == null)
            {
                this.head = prev;
                return;
            }

            var temp = currentNode.next;
            currentNode.next = prev;
            prev = currentNode;
            currentNode = temp;

            revLL(prev, currentNode);
        }

        public Node ReverseList(Node head)
        {   
            if(head.next == null)
            {
                this.head = head;
                return head;
            }

            var temp = ReverseList(head.next);
            temp.next = head;
            head.next = null;
            return head;
        
        }


        public void Print()
        {

            if (this.head == null)
            {
                Console.WriteLine("Link is empty!!");
                return;
            }
            var currentNode = this.head;

            while (currentNode != null)
            {
                Console.WriteLine(currentNode.data);
                currentNode = currentNode.next;
            }

        }
        public void AddNewNode(int data)
        {

            //If head is null the allocating head
            if (this.head == null)
            {
                this.head = new Node(data);
                Console.WriteLine("New node added!!!");
                this.length++;
                return;
            }

            var currentNode = this.head;

            //Itirating till we get last node of the list
            while (currentNode.next != null)
            {
                currentNode = currentNode.next;
            }

            currentNode.next = new Node(data);
            this.length++;
            Console.WriteLine("New node added!!!");
        }

    }
}

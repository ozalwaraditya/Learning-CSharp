using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace LearningC_.Linked_List
{
    public class DoublyLinkedList
    {
        public static void main(string[] args)
        {
            CustomDoublyLinkedList dll = new CustomDoublyLinkedList();

            dll.AddNewNode(10);
            dll.AddNewNode(12);
            dll.AddNewNode(13);
            dll.AddNewNode(16);
            dll.AddNewNode(15);
            dll.RemoveNode(16);

            Console.WriteLine("Original : ---");
            dll.Print();
            Console.WriteLine("Reverse Order : ----");
            dll.TraverseInReverse();
            Console.WriteLine("Search element: ----");
            //dll.Search(12);
            dll.Reverse();
            Console.WriteLine("Current tail : " + dll.head.data);

            Console.WriteLine("Reversed List : ---");
            dll.Print();

        }

    }

    public class DNode
    {
        public int data;
        public DNode next;
        public DNode prev;
        public DNode()
        {
            this.next = null;
            this.prev = null;
        }
    }


    public class CustomDoublyLinkedList
    {
        public DNode head;
        public DNode tail;
        public int length;
        
        //Print all elements
        public void Print()
        {

            if (this.head == null)
            {
                Console.WriteLine("Link is empty!!");
                return;
            }
            var currentNode = this.head;

            while (currentNode!= null)
            {
                Console.WriteLine(currentNode.data);
                currentNode = currentNode.next;
            }

        }
        
        //Add new Node
        public void AddNewNode(int data)
        {
            if(this.head == null)
            {
                this.head = new DNode();
                this.head.data = data;
                this.tail = this.head;
                return;
            }

            var currentNode = this.head;
            while (currentNode.next != null) {
                currentNode = currentNode.next;
            }

            var newNode = new DNode();
            newNode.data = data;
            newNode.prev = currentNode;
            currentNode.next = newNode;
            this.tail = newNode;

            Console.WriteLine("Added new node");
            return;
        }

        //Remove Node
        public void RemoveNode(int data)
        {
            // If head is empty
            if(this.head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }


            //Removing head
            if (head.data == data) { 
                this.head = this.head.next;

                if(head != null ) { head.prev = null;  }

                Console.WriteLine("Node is removed!!!");
                return;
            }

            var currentNode = this.head;
            while (currentNode.next != null)
            {
                if (currentNode.next.data == data)
                {
                    currentNode.next = currentNode.next.next;

                    if (currentNode.next.next != null)
                    {
                        currentNode.next.next.prev = currentNode;
                    }


                    Console.WriteLine("Node is removed");
                    return;
                }
                currentNode = currentNode.next;
            }

            Console.WriteLine("Data not found in the list!!!");
            return;
        }

        // Traverse Reverse with the help of tail
        public void TraverseInReverse()
        {
            if(this.head == null)
            {
                Console.WriteLine("The list is empty");
                return;
            }
            var currentNode = this.tail;
            while(currentNode != null)
            {
                Console.WriteLine(currentNode.data);
                currentNode = currentNode.prev;
            }
            return;
        }
        
        //Search Element
        public void Search(int data)
        {
            if (this.head == null)
            {
                Console.WriteLine("The list is empty!!!");
            }

            var currentNode = this.head;
            int index = 0;
            while (currentNode != null)
            {
                if(currentNode.data == data)
                {
                    Console.WriteLine("Element found at index : " + index);
                    return;
                }
                index++;
                currentNode = currentNode.next;
            }

            Console.WriteLine("Element not exists in the list");
            return;
        }

        //Search At Index
        public void SearchAtIndex(int index)
        {
            if (this.length == 0)
            {
                Console.WriteLine("This list is empty");
                return;
            }

            //Index checking
            if (index < 0 || this.length <= index)
            {
                Console.WriteLine("Invalid index!!!!!");
                Console.WriteLine("There are total : " + this.length);
                return;
            }
            var currentNode = this.head;
            for (int i = 0; i < index; i++)
            {
                currentNode = currentNode.next;
            }
            Console.WriteLine("Element at " + index + " : " + currentNode.data);
            return;
        }
    
        //Reverse
        public void Reverse()
        {
            if(this.length == 0)
            {
                Console.WriteLine("List is already empty!!");
            }
            
            if(this.length == 1)
            {
                Console.WriteLine("No need to reverse the list");
            }

            var firstNode = this.head.prev;
            var currentNode = this.head;

            this.tail = this.head;


            while (currentNode != null) {
                var temp = currentNode.next;
                currentNode.next = firstNode;
                currentNode.prev = temp;
                firstNode = currentNode;
                currentNode = temp;
            }

            this.head = firstNode;
            Console.WriteLine("Doubly linked list is reversed!!!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using LearningC_.Codes.ShowTableUsingLoops;

namespace LearningC_.Linked_List
{
    class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
    public class LinkedList
    {
        public static void main(string[] args)
        {
            Node one = new Node(1);
            Node two = new Node(2);
            Node three = new Node(3);
            Node head = one;
            Console.WriteLine("What does the Node clas node means : -" + one);
            while (head.next != null)
            {
                Console.WriteLine(head.data + " ");
                head = head.next;
            }

            CustomLinkedList ll = new CustomLinkedList();
            ll.AddNewNode(11);
            ll.AddNewNode(12);
            ll.AddNewNode(13);
            ll.AddNewNode(14);
            ll.AddNewNode(15);
            ll.AddNewNode(16);
            ll.RemoveNode(11);

            Console.WriteLine();
            Console.WriteLine("-----");
            ll.Print();
            Console.WriteLine();
            //ll.RemoveAllElements();
            ll.SearchAtIndex(5);

            ll.Reverse();
            Console.WriteLine("List is reverse ");

            ll.Print();
        }
    }

    class CustomLinkedList
    {
        public Node head;
        public int length;

        //Printing the Complete List
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

        //Add New Node from list 
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

        //Remove node from list
        public void RemoveNode(int data)
        {
            // Check the list is empty or not
            if (this.head == null)
            {
                Console.WriteLine("Link is already empty!!");
                return;
            }

            // Remove the head if the data found at the start
            if (this.head.data == data)
            {
                var removedNode = this.head;
                this.head = this.head.next;

                // Allocating
                removedNode.next = null;
                removedNode = null;
                this.length--;
                return;
            }
            var currentNode = this.head;

            //taking current pointer to last node
            while (currentNode.next != null)
            {

                //Stopping before the removable node
                if (currentNode.next.data == data)
                {
                    currentNode.next = currentNode.next.next;
                    Console.WriteLine("The node is remove");
                    this.length--;
                    return;
                }
                currentNode = currentNode.next;
            }

            Console.WriteLine("Number not found");
            return ;

        }

        // Search data in the list    
        public void Search(int data)
        {
            if (this.head == null)
            {
                Console.WriteLine("List is empty!!");
                return;
            }
            int index = 0;
            var currentNode = this.head;
            while (currentNode != null)
            {
                if (currentNode.data == data)
                {
                    Console.WriteLine("Object found at index : " + index);
                    return;
                }
                index++;
                currentNode = currentNode.next; 
            }
            Console.WriteLine("Object does not exists!!!");
            return;
        }

        //Search element at indexdity#14AOZ
        public void SearchAtIndex(int index)
        {
            if (this.length == 0)
            {
                Console.WriteLine("This list is empty");
                return;
            }

            //Index checking
            if(index < 0 || this.length <= index)
            {
                Console.WriteLine("Invalid index!!!!!");
                Console.WriteLine("There are total : " + this.length);
                return;
            }
            var currentNode = this.head;
            for(int i = 0; i < index ; i++)
            {
                currentNode = currentNode.next;
            }
            Console.WriteLine("Element at " + index + " : " + currentNode.data);
            return;
        }
        //Remove all elements
        public void RemoveAllElements()
        {
            if(this.head == null)
            {
                Console.WriteLine("List is already empty!!!");
            }

            var currentNode = this.head;
            while(currentNode != null)
            {
                var removeNode = currentNode;
                removeNode = null;
                currentNode = currentNode.next;
            }
            this.head = null;
            Console.WriteLine("Removed all elements from the list");
            return;
        }
    
        //Reverse the linked list
        public void Reverse()
        {
            if(this.length == 0)
            {
                Console.WriteLine("This list is empty!!!");
            }
            
            if(this.length == 1)
            {
                Console.WriteLine("Head will remains the same!!!");
                return;
            }
            //For two elements
            if(this.length == 2)
            {
                var cNode = this.head.next;

                this.head.next = null;
                cNode.next = this.head;
                this.head = cNode;
                Console.WriteLine("Linked list is reversed!!!");
                return;
            }

            var firstNode = this.head;
            var currentNode = firstNode.next;
            firstNode.next = null;

            while (currentNode != null)
            {
                var temp = currentNode.next;
                currentNode.next = firstNode;
                firstNode = currentNode;
                currentNode = temp;
            }

            this.head = firstNode;
            Console.WriteLine("Linked list is reversed!!!");
            return;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;

namespace LearningC_.Linked_List
{
    public class CircularLinkedList
    {
        public static void Main(string[] args)
        {
            CustomCircularLinkedList cll = new CustomCircularLinkedList();
            cll.AddNewNode(1);
            cll.AddNewNode(3);
            cll.AddNewNode(5);
            cll.AddNewNode(12);
            cll.Print();
            cll.SearchAtIndex(0);
        }
    }

    //Node class for linked list
    public class CNode
    {
        public int data;
        public CNode next;
        public CNode()
        {
            this.next = null;
        }
    }

    //Custom Circular Linked List
    public class CustomCircularLinkedList
    {
        public CNode head;
        public CNode tail;
        public int length;

        //Print the list.....
        public void Print()
        {
            if (this.head == null)
            {
                Console.WriteLine("List is empty!!");
                return;
            }
            var currentNode = this.head;
            
            do
            {
                Console.WriteLine(currentNode.data);
                currentNode = currentNode.next;
            } while (currentNode != head);
            
        }
        
        //Add new node in list
        public void AddNewNode(int data)
        {
            if (this.head == null && this.tail == null)
            {
                this.head = new CNode();
                this.head.data = data;
                this.head.next = this.head;
                this.tail = head;
                this.length++;
                Console.WriteLine("Added new node!!!");
                return;
            }
            
            var currentNode = this.head;

            while(currentNode.next != this.head)
            {
                currentNode = currentNode.next;
            }
            
            var newCNode = new CNode();
            this.tail = newCNode;
            currentNode.next = newCNode;
            newCNode.data = data;
            newCNode.next = this.head;
            this.length++;
            Console.WriteLine("Added new node!!!");
        }

        //Remove node from list
        public void Remove(int data) { 
            if(this.head == null)
            {
                Console.WriteLine("List is already empty!!!");
                return;
            }

            // To remove head
            if(this.head.data == data)
            {
                // If Head and tail are same Else Traverse head
                if (this.tail == this.head) 
                {
                    this.head = null;
                    this.tail = null;
                    Console.WriteLine("Node Removed from list");
                    return;
                }
                else
                {
                    var removeNode = this.head;
                    this.head = this.head.next;
                    this.tail.next = this.head;
                    removeNode = null;
                    Console.WriteLine("Node Removed from list");
                    return;
                }
            }

            var currentNode = this.head;
            //Traverse till tail
            while (currentNode.next != this.head)
            {
                if (currentNode.next.data == data)
                {
                    var removeNode = currentNode.next;
                    currentNode.next = removeNode.next;
                    if (removeNode == this.tail)
                    {
                        this.tail = currentNode;
                    }
                    removeNode = null;
                    Console.WriteLine("Node Removed from list");
                    return;
                }
                currentNode = currentNode.next;
            }
            Console.WriteLine("Element does not exists in the list!!!");
            return;
        }
    
        // Search in list 
        public void Search(int data)
        {
            if (head == null)
            {
                Console.WriteLine("The list is empty");
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
       
        //Searh at index
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
        
    }
}

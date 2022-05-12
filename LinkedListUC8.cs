using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UC8_SearchAndInsert
{
    internal class LinkedListUC8
    {
        //Creating a head node to point the first element
        public Node head;
        //Creating a method to insert last 

        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the linked list", node.data);
        }
        
        
        //Searching the particular element in linked list
        public Node Search(int value)
        {
            Node temp = this.head;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    Console.WriteLine("Element found.. " + value);
                    return temp;
                }
                temp = temp.next;

            }
            Console.WriteLine("Element not found!!!!!!!!");
            return default;
        }
        //Searching the particular element
        //-->If element is found,then after that insert the element..
        public int Insert(int searchdata, int data)
        {
            Node temp = Search(searchdata);
            Node newNode = new Node(data);
            newNode.next = temp.next;
            temp.next = newNode;
            return (newNode.data);

        }
        
        
        


        //Display the nodes
        public void Display()
        {
            Console.WriteLine("**********Displaying Nodes************");
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is Empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine(" " + temp.data + " ");
                    temp = temp.next;
                }
            }
        }
    }
}

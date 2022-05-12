using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC10_SortingLinkedlist
{
    internal class LinkedListUC10
    {
        //Creating a head node to point the first element
        public Node head;
        //Creating a method to insert 

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

        public void Sort()
        {
            Node i, j;
            int temp;
            for (i = this.head; i.next != null; i = i.next)
            {
                for (j = i.next; j != null; j = j.next)
                {
                    if (i.data > j.data)
                    {
                        temp = i.data;
                        i.data = j.data;
                        j.data = temp;
                    }
                }
            }
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

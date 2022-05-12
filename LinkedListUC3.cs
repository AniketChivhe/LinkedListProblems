using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC3_Appending
{
    internal class LinkedListUC3
    {
        internal Node head; //new 
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

        public void Append(int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.data = new_data;//assign data element
            new_node.next = null;//assign null to next of new node
                                 //check linkedlist empty 
            if (head == null)
            {
                head = new_node;

            }
            else
            {
                //traverse to last node
                Node temp = new Node(new_data);
                temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = new_node;

            }
        }



        internal void Display()
        {
            Console.WriteLine("***Displaying Nodes***");
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next; //temp=null
            }

        }    
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC9_SearchAndDelete
{
    internal class LinnkedListUC9
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
        



        //search and delete

        public int DeleteInBetween(int data)
        {
            Node temp = Search(data);
            Console.WriteLine("Data {0} has been deleted from linked list", temp.data);
            temp.next = temp.next.next;
            int sizeofList = Size();
            return sizeofList;
        }

        public int Size()
        {
            int count = 0;
            Node temp = this.head;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
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

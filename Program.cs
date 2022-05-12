using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UC2_LinkedList;

namespace LinkedListProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom To Linked List Program UC2");
            LinkedListUC2 list = new LinkedListUC2();
            list.Add(56);
            list.Add(30);
            list.Add(70);

            list.Display();
            Console.ReadKey();

        }
    }
}
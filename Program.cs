using System;

namespace UC10_SortingLinkedlist
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedListUC10 list = new LinkedListUC10();
            list.Add(56);
            list.Add(30);
            list.Add(40);
            list.Add(70);
            Console.WriteLine("Sorting Of Linked List");
            list.Sort();

            list.Display();
            Console.ReadLine();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC6_DeleteLast
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom To Linked List Program UC3");
            LinkedListUC6 list = new LinkedListUC6();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.RemovaLastNode();
            Console.WriteLine("Last element deleted");
            list.Display();
            Console.ReadKey();

        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC5_DeleteFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom To Linked List Program UC3");
            LinkedListUC5 list = new LinkedListUC5();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.RemoveFirstNode();
            Console.WriteLine("first element deleted");
            list.Display();
            Console.ReadKey();

        }
    }
}

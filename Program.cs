using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC3_Appending
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom To Linked List Program UC3");
            LinkedListUC3 list = new LinkedListUC3();
            list.Add(56);
            list.Append(30);
            list.Append(70);

            list.Display();
            Console.ReadKey();

        }
    }
}

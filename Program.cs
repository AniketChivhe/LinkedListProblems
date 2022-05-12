using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC4_InsertInBetween
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom To Linked List Program UC3");
            LinkedListUC4 list = new LinkedListUC4();
            list.Add(56);
            list.Add(70);
            list.InsertAtParticularPosition(2, 30);

            list.Display();
            Console.ReadKey();

        }
    }
}

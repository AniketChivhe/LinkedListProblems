using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC7_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom To Linked List Program UC3");
            LinkedListUC7 list = new LinkedListUC7();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();

            Console.WriteLine("Enter any of 56,30,70 to Find in Linked list: ");

            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 56:
                    list.Search(56);
                    break;
                case 30:
                    list.Search(30);
                    break;
                case 70:
                    list.Search(70);
                    break;
            }
            Console.ReadKey();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC8_SearchAndInsert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom To Linked List Program UC8");
            LinkedListUC8 list = new LinkedListUC8();
            list.Add(56);
            list.Add(30);
            list.Add(70);

            Console.WriteLine("\n Enter any of 56,30,70 to Find in Linked list and add 40 to next : ");

            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 56:
                    list.Search(56);
                    list.Insert(56, 40);
                    break;
                case 30:
                    list.Search(30);
                    list.Insert(30, 40);
                    break;
                case 70:
                    list.Search(70);
                    list.Insert(70, 40);
                    break;
            }
            list.Display();
            Console.ReadKey();
        }
    }
}



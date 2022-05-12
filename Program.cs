using System;

namespace UC9_SearchAndDelete
{
    class Program
    {
        static void Main(string[] args)
        {
            
            LinnkedListUC9 list = new LinnkedListUC9();
            list.Add(56);
            list.Add(30);
            list.Add(40);
            list.Add(70);
            list.Search(40);
            list.DeleteInBetween(40);
            

            list.Display();
            Console.ReadLine();
        }
                  
    }
}

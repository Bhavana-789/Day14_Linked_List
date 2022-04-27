using System;
using System.Collections.Generic;


namespace Linked_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedList<int> list = new CustomLinkedList<int>(); 
            list.AddFirst(70); 
            list.AddFirst(30); 
            list.AddFirst(56); 
            list.DisplayElement();
            Console.ReadLine();
        }
    }
}

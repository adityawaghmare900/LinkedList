﻿namespace RemoveFirstNode_UC5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list= new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            Console.WriteLine();
            Console.WriteLine("=========================================");
            list.RemoveFirstNode();
            Console.WriteLine();
            Console.WriteLine("=========================================");
            Console.WriteLine("After removing First element");
            list.Display();
        }

    }
}
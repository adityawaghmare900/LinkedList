using System.Collections.Generic;

namespace LinkedListWithNode_UC2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            LinkedList list = new LinkedList();
            list.AddNode(70);
            list.AddNode(30);
            list.AddNode(56);

            list.Display();
        }
    }
}
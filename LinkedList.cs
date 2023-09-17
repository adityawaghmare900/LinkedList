using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveFirstNode_UC5
{
    internal class LinkedList
    {
        internal Node head;
        
        internal void Add(int data)
        {
            Node node = new Node(data);
            if(this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next!= null)
                {
                    temp=temp.next;
                }
                temp.next= node;
            }
            Console.WriteLine("{0} inserted into linked list",node.data);
        }

        public void Display()
        {
            Node temp = this.head;
            if(temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while(temp != null)
            {
                Console.WriteLine(temp.data+" ");
                temp=temp.next;
            }
        }

        public Node RemoveFirstNode()
        {
            if (this.head == null)
            {
                return null;
            }
            this.head = this.head.next;
            Console.WriteLine("Fisrt Element Deleted Successfully");
            return this.head;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertAtOnePosition_UC4
{
    public class LinkedList
    {
        public Node head;

        public void Add(int data)
        {
            Node node=new Node(data);
            if(this.head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null) 
                {
                    temp=temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} is inserted into the liinkedList", data);
        }

        public void Display()
        {
            Node temp = this.head;
            if (temp == null) 
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

        internal int Search(int value)
        {
            Node node = this.head;
            int count = 0;
            while (node != null)
            {
                if (node.data == value)
                {
                    return count;
                }
                node = node.next;
                count++;
            }
            return count;
        }
        public Node InsertAtPerticularPostion(int position, int data)
        {
            if(position<1)
            {
                Console.WriteLine("Invalid position");
            }
            if(position ==1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head=newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
                if (position != 1)
                    Console.WriteLine("Position out o range");
            }
            return head;

        }
    }
}

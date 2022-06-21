using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class LinkedList
    {
        public Node head;

        public bool Add(int data)
        {
            Node node = new Node(data);

            if(head == null)
            {
                head = node;
            }
            node.next = head;
            head = node;
            return true;

        }

        public bool Append(int data)
        {
            Node node = new Node(data);

            if(head == null)
            {
                head = node;
            }

            Node t = head;

            while(t.next!=null)
            {
                t = t.next;

            }
            t.next = node;
            return true;
        }

        public void Display()
        {
            Node t = head;

            while(t!=null)
            {
                Console.WriteLine(t.data);
                t = t.next;
            }
        }
    }
}

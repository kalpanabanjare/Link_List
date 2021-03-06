using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    public class linkList
    {
        public Node Head;
        public Node Tail;
        public linkList()
        {
            Head = null;
            Tail = null;
        }
        public void AddNode(Node node)
        {
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.next = Head;
                Head = node;
            }
        }       
        internal void Display()
        {
            Node temp = Head;
            if (temp == null)
            {
                Console.WriteLine("LinkList is empty"); 
            }
            else
            {
                Console.WriteLine("LinkList as follows: ");
            }
            while (temp != null)
            {
                Console.Write(temp.data);
                if (temp.next != null)
                {
                    Console.Write("->"); 
                }
                temp = temp.next;
            }
        }
        public void AppendNode(Node node)
        {
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.next = node;
                Tail = node;
            }
        }
        public void AddNodeatStart(Node node)
        {
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.next = Head;
                Head = node;
            }
        }
        public void DeleteNodeAtFirst()
        {
            if (this.Head == null)
            {
                Console.WriteLine("Nothig to delete");
            }
            Node temp = this.Head;
            this.Head = this.Head.next;
            Console.WriteLine("\nRemoved first node from LinkList");
        }
        public void DeleteNodeAtLast()
        {
            if (Head == null)
            {
                Console.WriteLine("Nothing to delete");
            }
            else
            {
                Node temp = Head;
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }
                Tail = temp;
                Console.WriteLine("\nRemoved last node from linklist", temp.next.data);
                temp.next = null;
            }
        }
        public bool search(int data)
        {
            Node temp = this.Head;
            while (temp != null)
            {
                if (temp.data == data)
                {
                    return true;
                }
                temp = temp.next;
            }
            return false;
        }
        public void AddSpicificNode(int data, Node node)
        {
            Node temp = Head;
            while (temp != null)
            {
                if (temp.data == data)
                {
                    node.next = temp.next;
                    temp.next = node;
                }
                temp = temp.next;
            }
        }
        public void DeleteSpecific(int Data)
        {
            Node temp = Head;
            while (temp != null)
            {
                if (temp.data == Data)
                {
                    Head = temp.next;
                    temp = null;
                    break;
                }
                else if (temp.next.data == Data)
                {
                    temp.next = temp.next.next;
                    break;
                }
                temp = temp.next;
            }
        }
    }
}

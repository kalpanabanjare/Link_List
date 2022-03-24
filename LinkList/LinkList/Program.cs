using System;
using System.Collections.Generic;

namespace LinkList
{
    class program
    {
        static void Main()
        {
            linkList linklist = new linkList();
            Node node1 = new Node(21);
            Node node2 = new Node(22);
            Node node3 = new Node(23);
            Node node4 = new Node(24);
            Node node5 = new Node(25);

            linklist.AddNode(node1);
            linklist.AddNode(node2);
            linklist.AddNode(node3);
            linklist.AddNode(node4);
            linklist.AddNode(node5);
            linklist.Display();

            Node node6 = new Node(20);
            Console.WriteLine("\nAfter append node:");
            linklist.AppendNode(node6);
            linklist.Display();
            
            Node node0 = new Node(30);
            Console.WriteLine("\nAdd node to first");
            linklist.AddNodeatStart(node0);
            linklist.Display();

            linklist.DeleteNodeAtFirst();
            linklist.Display();

            linklist.DeleteNodeAtLast();
            linklist.Display();

            Console.WriteLine("\nEnter number you want to search");
            int data = int.Parse(Console.ReadLine());
            bool res = linklist.search(data);
            if (res == true)
            {
                Console.WriteLine("Data found");
            }
            else
            {
                Console.WriteLine("Data not found");
            }
            Node node7 = new Node(100);
            Console.WriteLine("\nEnter a number after you want to add: ");
            int Data = int.Parse(Console.ReadLine());
            linklist.AddSpicificNode(Data, node7);
            linklist.Display();                  
        }
    }
}

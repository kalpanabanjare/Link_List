using System;
using System.Collections.Generic;

namespace LinkList
{
    class program
    {
        static void Main()
        {
            linkList linklist = new linkList();
            Node node_1 = new Node(21);
            Node node_2 = new Node(22);
            Node node_3 = new Node(23);
            Node node_4 = new Node(24);
            Node node_5 = new Node(25);

            linklist.AddNode(node_1);
            linklist.AddNode(node_2);
            linklist.AddNode(node_3);
            linklist.AddNode(node_4);
            linklist.AddNode(node_5);
            linklist.Display();

            Node node_6 = new Node(20);
            Console.WriteLine("\nAfter append node:");
            linklist.AppendNode(node_6);
            linklist.Display();
            
            Node node_0 = new Node(30);
            Console.WriteLine("\nAdd node to first");
            linklist.AddNodeatStart(node_0);
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
            Node node_7 = new Node(100);
            Console.WriteLine("\nEnter a number after you want to add: ");
            int Data = int.Parse(Console.ReadLine());
            linklist.AddSpicificNode(Data, node_7);
            linklist.Display();                  
        }
    }
}
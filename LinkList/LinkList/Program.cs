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
            linklist.DeleteNodeAtFirst();
            linklist.Display();
        }
    }
}

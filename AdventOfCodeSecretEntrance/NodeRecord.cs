using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCodeSecretEntrance
{
    public class Node
    {
        public int data;
        public Node next;
        public Node previous;
        public Node tail;
        public Node head;

        public Node(int data)
        {
            this.data = data;
            this.next = null;
            this.previous = null;
            this.head = null;
        }
    }
}

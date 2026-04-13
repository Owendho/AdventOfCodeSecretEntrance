using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCodeSecretEntrance
{
    public class SMLinkedList
    {
        public void TraveserseLinkedList(Node head)
        {
            while (head != null)
            {
                Console.WriteLine(head.data + " ");
                if (head.next != null)
                {
                    Console.Write(" -> ");
                }
                head = head.next;
            }
            Console.WriteLine();
        }

        public Node InsertAfterNode(Node prevNode, int x)
        {
            Node newNode = new Node(x);
            prevNode.next = newNode;
            return newNode; //return new node so that it can be used in a loop
        }

        public Node InsertAtFront(Node head, int x)
        {
            Node newNode = new Node(x);
            newNode.next = head;
            return newNode;
        }


        public Node InsertAtBeginning(Node last, int key) //cicular linked list
        {
            Node newNode = new Node(key);

            if (last == null)
            {
                newNode.next = newNode;
                return newNode;
            }

            if (last.next == null)
            {
                last.next = last;
            }
            newNode.next = last.next; //new node points to the head? the newNode points to the head because it becomes the new head
            last.next = newNode; //last node points to 

            return last;
        }


        public Node InsertAtEnd(Node tail, int key) // circular linked list
        {
            Node newNode = new Node(key);

            if (tail == null)
            {
                newNode.next = newNode;
                newNode.previous = newNode;
                return newNode;
            }

            if (tail.next == null)
            {
                tail.next = tail;
            }

            Node head = tail.next;


            if (tail.previous == null)
            {
                tail.previous = tail;
            }

            newNode.next = head; //why is head null. must because tail.next is null
            newNode.previous = tail; //why is tail null

            tail.next = newNode;
            head.previous = newNode; //why is newnode null


            return newNode;
        }

        public void printLinkedList(Node head)
        {
            if (head == null) return;

            Node temp = head;

            while (true)
            {
                if (temp.next != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                    if (temp != head && temp.next != null)
                    {
                        Console.Write(" -> ");
                    }
                    else
                    {
                        break; //do this to stop printing after reaching the end of the list
                    }
                }
            }
            Console.WriteLine();
        }

        public int TraverseListRight(Node head, int traversalDepth)
        {
            if (head == null) return 0; //change this null check
                                        //int zeroCount = 0; 
            int nodeData = 0; //position in the list
            Node temp = head;
            for (int i = 0; i <= traversalDepth; i++)
            {
                if (temp != null)
                {
                    //Console.WriteLine(temp.data);
                    if (i == traversalDepth)
                    {
                        nodeData = temp.data;
                        return nodeData;
                    }
                    temp = temp.next;
                }
            }
            return nodeData;
        }


        public int TraverseListRightThenLeft(Node head, int traversalDepthRight, int traversalDepthLeft)
        {
            if (head == null) return 0; //change this null check
                                        //int zeroCount = 0; 
            int nodeData = 0; //position in the list
            Node temp = head;
            for (int i = 0; i <= traversalDepthRight; i++)
            {
                if (temp != null)
                {
                    //Console.WriteLine(temp.data);
                    if (i == traversalDepthRight)
                    {
                        //nodeData = temp.data;
                        //return nodeData; //for loop going in the opposite direction here
                        
                        for (int j = 0; j < traversalDepthLeft; j++)
                        {
                            if (temp != null)
                            {
                                //Console.WriteLine(temp.data);
                                if (j == traversalDepthLeft)
                                {
                                    nodeData = temp.data;
                                }
                                temp = temp.previous;
                            }
                        }
                    }
                    temp = temp.next;
                }
            }
            return nodeData;
        }
        public int TraverseListLeft(Node head, int traversalDepth)
        {
            if (head == null) return 0; //change this null check
                                        //int zeroCount = 0; 
            int nodeData = 0; //position in the list
            Node temp = head;
            for (int i = 0; i < traversalDepth; i++)
            {
                if (temp != null)
                {
                    //Console.WriteLine(temp.data);
                    if (i == traversalDepth)
                    {
                        nodeData = temp.data;
                    }
                    temp = temp.previous;
                }
            }
            return nodeData;
        }

        public int TraverseListLeftThenRight(Node head, int traversalDepthLeft, int traversalDepthRight)
        {
            if (head == null) return 0; //change this null check
                                        //int zeroCount = 0; 
            int nodeData = 0; //position in the list
            Node temp = head;
            for (int i = 0; i < traversalDepthLeft; i++)
            {
                if (temp != null)
                {
                    //Console.WriteLine(temp.data);
                    if (i == traversalDepthLeft)
                    {
                        for (int j = 0; i <= traversalDepthRight; j++)
                        {
                            if (temp != null)
                            {
                                //Console.WriteLine(temp.data);
                                if (j == traversalDepthRight)
                                {
                                    nodeData = temp.data;
                                    return nodeData;
                                }
                                temp = temp.next;
                            }
                        }
                    }
                    temp = temp.previous;
                }
            }
            return nodeData;
        }
    }
}

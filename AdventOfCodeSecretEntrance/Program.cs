// See https://aka.ms/new-console-template for more information
using AdventOfCodeSecretEntrance;

Console.WriteLine("Hello, World!");

//Might be better of making my own circular linked list from scratch
//need to make my own circular doubly linked list 



//Node head = new Node(12);

//head.next = new Node(56);

//head.next.next = new Node(55);

//Node temp = head;

/*
while (temp != null)
{
    Console.WriteLine(temp.data + " ");
    temp = temp.next;
}*/

Node head = new Node(0);
//InsertAfterNode(head, 2);

Node current = head;

for (int i = 1; i < 100; i++)
{
    current = InsertAfterNode(current, i);
}

TraveserseLinkedList(head);

/*LinkedList<int> safeDial = new LinkedList<int>();
safeDial.AddFirst(0);

LinkedListNode<int> current = safeDial.First;
for (int i = 1; i < 99; i++)
{
    safeDial.AddAfter(current, i);
    current = safeDial.Last;
}

Console.WriteLine(safeDial.Count());
*/

//LinkedListNode<int> 

//Create a method called head.previous

static LinkedListNode<int> headPrevious(LinkedList<int> safeDial)
{
    return safeDial.Last;
}

static LinkedListNode<int> tailNext(LinkedList<int> safeDial)
{
    return safeDial.First;
}

//Write method to populate list



static void TraveserseLinkedList(Node head)
{
    while(head != null)
    {
        Console.WriteLine(head.data + " ");
        if(head.next != null)
        {
            Console.Write(" -> ");
        }
        head = head.next;
    }
    Console.WriteLine();
}

static Node InsertAfterNode(Node prevNode, int x)
{
    Node newNode = new Node(x);
    prevNode.next = newNode; 
    return newNode; //return new node so that it can be used in a loop
}

static Node InsertAtFront(Node head, int x)
{
    Node newNode = new Node(x);
    newNode.next = head;
    return newNode;
}

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

for (int i = 1; i < 100; i++) //changed to 3 temporarily
{
    //current = InsertAfterNode(current, i);
    //InsertAtEnd(head, i);
    InsertAtBeginning(head, i);
}

//TraveserseLinkedList(head);
printLinkedList(head);


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


static Node InsertAtBeginning(Node last, int key) //cicular linked list
{
    Node newNode = new Node(key);

    if (last == null)
    {
        newNode.next = newNode;
        return newNode;
    }

    if(last.next == null)
    {
        last.next = last;
    }
    newNode.next = last.next; //new node points to the head? the newNode points to the head because it becomes the new head
    last.next = newNode; //last node points to 

    return last;
}


static Node InsertAtEnd(Node tail, int key) // circular linked list
{
    Node newNode = new Node(key);

    if (tail == null)
    {
        newNode.next = newNode;
        return newNode;
    }

    if(tail.next == null)
    {
        tail.next = tail;
    }
    //new node needs to become last node
    Node head = tail.next;
    newNode.next = head;

    tail.next = newNode;

    tail = newNode;

    return tail;
}

//edit print statement so that it prints 1,2,3 instead of 3,2,1
static void printLinkedList(Node last)
{
    if (last == null) return;

    Node head = last.next;
    Node temp = head;

    while (true)
    {

        Console.WriteLine(temp.data);
        temp = temp.next;
        if (temp != head)
        {
            Console.Write(" -> ");
        }
        else
        {
            break; //do this to stop printing after reaching the end of the list
        }
    }
    Console.WriteLine();
}



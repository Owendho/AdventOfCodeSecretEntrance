// See https://aka.ms/new-console-template for more information
using AdventOfCodeSecretEntrance;

Console.WriteLine("Hello, World!");

//Might be better of making my own circular linked list from scratch
//need to make my own circular doubly linked list 




Node head = new Node(0);
//InsertAfterNode(head, 2);

Node current = head;

for (int i = 1; i < 101; i++) //changed to 3 temporarily
{
    //current = InsertAfterNode(current, i);
    current = InsertAtEnd(current, i);
    //current = InsertAtBeginning(current, i);
}

//Need to create method that reads input from a text file

//TraveserseLinkedList(head);
printLinkedList(head);

static void calculateZeros(string inputFromText)
{
    //create a forloop for the amount of input. if input starts with r forwards. if it starts with l then go backwards. start by traversing 50 nodes to the right
    int amountOfrows = 0;
    string direction = " ";
    int traversalDepth = 0;
    for (int i = 0; i < amountOfrows; i++)
    {

        if (direction == "R")
        {
            //traverse safe amount of traversal depth
        }

        if (direction == "L")
        {
            //traverse safe amount of traversal depth
        }
    }


}



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
        newNode.previous = newNode;
        return newNode;
    }

    if (tail.next == null)
    {
        tail.next = tail;
    }

    Node head = tail.next;
    
    


    
    if(tail.previous == null)
    {
        tail.previous = tail;
    }
    
    //tail.next = newNode; //why is this null?
    newNode.next = head; //why is head null. must because tail.next is null
    newNode.previous = tail; //why is tail null

    tail.next = newNode;
    head.previous = newNode; //why is newnode null


    return newNode;
}

static void printLinkedList(Node head)
{
    if (head == null) return;

    //Node head = last;
    Node temp = head;

    while (true)
    {
        if (temp.next != null) {
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

static void TraverseListRight(Node head, int traversalDepth)
{
    if (head == null) return;
    int zeroCount = 0; 

    Node temp = head;
    for (int i = 0; i < traversalDepth; i++)
    {
        if (temp != null)
        {
            //Console.WriteLine(temp.data);
            if (i == traversalDepth && temp.data == 0)
            {
                zeroCount++;
            }
            temp = temp.next;

        }
    }
}



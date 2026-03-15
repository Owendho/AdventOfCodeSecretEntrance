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

static void DialAtZeroCount(string inputFromText, Node head)
{
    //create a forloop for the amount of input. if input starts with r forwards. if it starts with l then go backwards. start by traversing 50 nodes to the right
    int amountOfrows = 0;
    string direction = " ";
    int lastTraversalDepth = 0;
    bool isOnStartPosition = true;
    bool traverseRight = false;
    bool traverseLeft = false;
    int tempTraversal = 0;
    int numberInputFromText = 0; //temp value

    for (int i = 0; i < amountOfrows; i++)
    {
        //start by traversing 50 to the right every time since the dial starts on 50. does it need to save the previous position. if so create variable called previous position
        //that stores a returned value from whichever if statement was hit. then traverse to that position before the next 'turn' of the dial. need to review the instructions the dial
        //does infact save the position. the dial also starts at 50
        if(isOnStartPosition)
        {
            lastTraversalDepth = TraverseListRight(head, 50);
            isOnStartPosition = false;
            traverseRight = true;
        }

        if (direction == "R")
        {
            if(traverseRight == true)
            {
                tempTraversal = TraverseListRight(head, lastTraversalDepth);
                lastTraversalDepth = TraverseListRight(head, numberInputFromText); //create method that splits text and returns the number and direction. 
                traverseRight = true; //maybe not have this line of code here

            }

            if (traverseLeft == true)
            {
                tempTraversal = TraverseListLeft(head, lastTraversalDepth);
                lastTraversalDepth = TraverseListRight(head, numberInputFromText);
            }

        }

        if (direction == "L")
        {
            TraverseListLeft(head, 0);

            if (traverseRight == true)
            {
                tempTraversal = TraverseListRight(head, lastTraversalDepth);
                lastTraversalDepth = TraverseListLeft(head, numberInputFromText); //create method that splits text and returns the number and direction. 
                traverseRight = true; //maybe not have this line of code here

            }

            if (traverseLeft == true)
            {
                tempTraversal = TraverseListLeft(head, lastTraversalDepth);
                lastTraversalDepth = TraverseListLeft(head, numberInputFromText);
            }
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

static int TraverseListRight(Node head, int traversalDepth)
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
            temp = temp.next;
        }
    }
    return nodeData;
}

static int TraverseListLeft(Node head, int traversalDepth)
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


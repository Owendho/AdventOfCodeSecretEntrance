// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Might be better of making my own circular linked list from scratch
//need to make my own circular doubly linked list 
LinkedList<int> safeDial = new LinkedList<int>();
safeDial.AddFirst(0);

LinkedListNode<int> current = safeDial.First;
for (int i = 1; i < 99; i++)
{
    safeDial.AddAfter(current, i);
    current = safeDial.Last;
}

Console.WriteLine(safeDial.Count());

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

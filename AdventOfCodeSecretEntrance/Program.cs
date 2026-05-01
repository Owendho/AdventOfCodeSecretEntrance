// See https://aka.ms/new-console-template for more information
using AdventOfCodeSecretEntrance;
using System.IO;

Console.WriteLine("Hello, World!");

//Might be better of making my own circular linked list from scratch
//need to make my own circular doubly linked list 


SMLinkedList linkedList = new SMLinkedList();
Dial dial = new Dial(linkedList);

Node head = new Node(0);
//InsertAfterNode(head, 2);

Node current = head;

for (int i = 1; i < 101; i++) //changed to 3 temporarily
{
    //current = InsertAfterNode(current, i);
    current = linkedList.InsertAtEnd(current, i);
    //current = InsertAtBeginning(current, i);
}

//Need to create method that reads input from a text file

//TraveserseLinkedList(head);
//printLinkedList(head);

//DialAtZeroCount()

//ReadInputFromFile();

//DialAtZeroCount(ReadInputFromFile(), head);

ReadInputFromFileTurnDial(head);



void ReadInputFromFileTurnDial(Node head) //include path parameter later. return string later
{
    string[] textInputArray = new string[5000];
    int i = 0;

    try
    {

        //using automatically closes file
        using (StreamReader sr = new StreamReader("C:\\Users\\owend\\Documents\\Adventofcode\\PuzzleInput.txt"))
        {
            string line = sr.ReadLine();
            string turnDirection = " ";
            string traversalDistance = " ";
            DialInfo dialInfo = new DialInfo(0, true, false, false);


            while (line != null)
            {
                Console.WriteLine(line);


                turnDirection = line.Substring(0, 1); //make null check. i suspect it returns null when it reaches the last line
                traversalDistance = line.Substring(1);
                dialInfo = dial.DialAtZeroCount(turnDirection, traversalDistance, head, dialInfo);

                textInputArray[i] = line;
                i++;

                line = sr.ReadLine();
            }

            Console.ReadLine();
            Console.WriteLine(dialInfo.ZeroCount);
        }

        //return textInputArray;
    }
    catch (Exception e) //modify exception handling logic. refine it
    {
        Console.WriteLine("Exception: " + e.Message);
    }
    finally
    {
        Console.WriteLine("Executing finally block.");
    }

    //return textInputArray;

}





string[] ReadInputFromFile() //include path parameter later. return string later
{
    string[] textInputArray = new string[5000];
    int i = 0;

    try
    {

        StreamReader sr = new StreamReader("C:\\Users\\owend\\Documents\\Adventofcode\\PuzzleInput.txt");

        string line = sr.ReadLine();

        while (line != null)
        {
            Console.WriteLine(line);

            line = sr.ReadLine();
            textInputArray[i] = line;
            i++;
        }
        //Close file
        sr.Close();
        Console.ReadLine();

        return textInputArray;
    }
    catch(Exception e)
    {
        Console.WriteLine("Exception: " + e.Message);
    }
    finally
    {
        Console.WriteLine("Executing finally block.");
    }

    return textInputArray;
}



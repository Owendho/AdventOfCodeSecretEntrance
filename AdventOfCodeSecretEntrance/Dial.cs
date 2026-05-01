using System;
using System.Collections.Generic;
using System.Text;


namespace AdventOfCodeSecretEntrance
{
    public class Dial
    {
        SMLinkedList _linkedList;
        public Dial(SMLinkedList linkedList) //Dependency inject
        {
            _linkedList = linkedList;
        }
        public DialInfo DialAtZeroCount(string turnDirection, string traversalDistance, Node head, DialInfo dialInfo)
        {
            //Can't define booleans here. need to define them in the dialInfo object
            //start by traversing 50 nodes to the right


            //temp value
            //start by traversing 50 to the right every time since the dial starts on 50. does it need to save the previous position. if so create variable called previous position
            //that stores a returned value from whichever if statement was hit. then traverse to that position before the next 'turn' of the dial. need to review the instructions the dial
            //does infact save the position. the dial also starts at 50

            if (dialInfo.IsOnStartPosition == true)
            {
                dialInfo.LastTraversalPosition = _linkedList.TraverseListRight(head, 50); //make this 50 again
                dialInfo.IsOnStartPosition = false;
                dialInfo.TraversedRight = true;
                dialInfo.TraversedLeft = false;
            }

            if (turnDirection == "R")
            {
                if (dialInfo.TraversedRight == true)
                {
                    //tempTraversal = _linkedList.TraverseListRight(head, lastTraversalDepth); //lasttraversal also need the direction
                    dialInfo.LastTraversalPosition = _linkedList.TraverseListRight(head, dialInfo.LastTraversalPosition + Int32.Parse(traversalDistance)); //what to do if the last traverasal was in the opposite direction?
                    dialInfo.TraversedRight = true;
                    dialInfo.TraversedLeft = false;

                    if (dialInfo.LastTraversalPosition == 0)
                    {
                        dialInfo.ZeroCount += 1;
                    }

                    dialInfo.IsOnStartPosition = false;


                }

                if (dialInfo.TraversedLeft == true)
                {
                    //tempTraversal = _linkedList.TraverseListLeft(head, lastTraversalDepth);
                    dialInfo.LastTraversalPosition = _linkedList.TraverseListLeftThenRight(head, dialInfo.LastTraversalPosition, Int32.Parse(traversalDistance)); //how to resolve traversing in opposite directions. need to combine travesrse right and left method
                    dialInfo.TraversedLeft = true;
                    dialInfo.TraversedRight = false;

                    if (dialInfo.LastTraversalPosition == 0)
                    {
                        dialInfo.ZeroCount += 1;
                    }

                    dialInfo.IsOnStartPosition = false;

                }
            }

            if (turnDirection == "L")
            {

                if (dialInfo.TraversedRight == true)
                {

                    dialInfo.LastTraversalPosition = _linkedList.TraverseListRightThenLeft(head, dialInfo.LastTraversalPosition, Int32.Parse(traversalDistance));
                    dialInfo.TraversedRight = false; 
                    dialInfo.TraversedLeft = true; 

                    if (dialInfo.LastTraversalPosition == 0)
                    {
                        dialInfo.ZeroCount += 1;
                    }

                    dialInfo.IsOnStartPosition = false;
                }

                if (dialInfo.TraversedLeft == true)
                {
                    dialInfo.LastTraversalPosition = _linkedList.TraverseListLeft(head, dialInfo.LastTraversalPosition + Int32.Parse(traversalDistance));
                    dialInfo.TraversedLeft = true;
                    dialInfo.TraversedRight = false;

                    if (dialInfo.LastTraversalPosition == 0)
                    {
                        dialInfo.ZeroCount += 1;
                    }

                    dialInfo.IsOnStartPosition = false;
                }
            }
            //dialInfo.LastTraversalPosition = lastTraversalDepth; //need to change this variable to lastTraversalDepth

            return dialInfo;
        }
    }
}

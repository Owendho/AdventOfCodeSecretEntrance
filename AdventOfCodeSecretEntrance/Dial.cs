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
            //start by traversing 50 nodes to the right
            string direction = turnDirection;
            int lastTraversalDepth = 0;
            bool isOnStartPosition = true;
            bool traverseRight = false;
            bool traverseLeft = false;
            int tempTraversal = 0;
            int numberInputFromText = 0; //this is the pointer value
            int zeroCount = 0;


            //temp value
            //start by traversing 50 to the right every time since the dial starts on 50. does it need to save the previous position. if so create variable called previous position
            //that stores a returned value from whichever if statement was hit. then traverse to that position before the next 'turn' of the dial. need to review the instructions the dial
            //does infact save the position. the dial also starts at 50

            if (dialInfo.IsOnStartPosition == true)
            {
                lastTraversalDepth = _linkedList.TraverseListRight(head, 3); //make this 50 again
                isOnStartPosition = false;
                traverseRight = true;
                traverseLeft = false;
            }

            if (direction == "R")
            {
                if (traverseRight == true)
                {
                    //tempTraversal = _linkedList.TraverseListRight(head, lastTraversalDepth); //lasttraversal also need the direction
                    lastTraversalDepth = _linkedList.TraverseListRight(head, lastTraversalDepth + Int32.Parse(traversalDistance)); //what to do if the last traverasal was in the opposite direction?
                    traverseRight = true;
                    traverseLeft = false;

                    if (lastTraversalDepth == 0)
                    {
                        dialInfo.ZeroCount += 1;
                    }

                    dialInfo.IsOnStartPosition = false;


                }

                if (traverseLeft == true)
                {
                    //tempTraversal = _linkedList.TraverseListLeft(head, lastTraversalDepth);
                    lastTraversalDepth = _linkedList.TraverseListLeftThenRight(head, lastTraversalDepth, Int32.Parse(traversalDistance)); //how to resolve traversing in opposite directions. need to combine travesrse right and left method
                    traverseLeft = true;
                    traverseRight = false;

                    if (lastTraversalDepth == 0)
                    {
                        dialInfo.ZeroCount += 1;
                    }

                    dialInfo.IsOnStartPosition = false;

                }

                if (direction == "L")
                {
                    _linkedList.TraverseListLeft(head, 0);

                    if (traverseRight == true)
                    {
                        //tempTraversal = _linkedList.TraverseListRight(head, lastTraversalDepth);
                        lastTraversalDepth = _linkedList.TraverseListRightThenLeft(head, lastTraversalDepth, Int32.Parse(traversalDistance));
                        traverseRight = true;
                        traverseLeft = false;

                        if (lastTraversalDepth == 0)
                        {
                            dialInfo.ZeroCount += 1;
                        }

                        dialInfo.IsOnStartPosition = false;
                    }

                    if (traverseLeft == true)
                    {
                        //tempTraversal = _linkedList.TraverseListLeft(head, lastTraversalDepth);
                        lastTraversalDepth = _linkedList.TraverseListLeft(head, lastTraversalDepth + Int32.Parse(traversalDistance));
                        traverseLeft = true;
                        traverseRight = false;

                        if (lastTraversalDepth == 0)
                        {
                            dialInfo.ZeroCount += 1;
                        }

                        dialInfo.IsOnStartPosition = false;
                    }
                }
            }
            dialInfo.LastTraversalPosition = tempTraversal;
            dialInfo.TraversalLeft = traverseLeft;
            dialInfo.TraversedRight = traverseRight;


            return dialInfo;
        }
    }
}

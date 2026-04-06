using System;
using System.Collections.Generic;
using System.Text;


namespace AdventOfCodeSecretEntrance
{
    public class Dial
    {
        LinkedList _linkedList;
        public Dial(LinkedList linkedList) //Dependency inject
        {
            _linkedList = linkedList;
        }
        public DialInfo DialAtZeroCount(string turnDirection, string traversalDistance, Node head, DialInfo dialInfo)
        {
            //start by traversing 50 nodes to the right
            string direction = " ";
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

            if (isOnStartPosition)
            {
                lastTraversalDepth = _linkedList.TraverseListRight(head, 50);
                isOnStartPosition = false;
                traverseRight = true;
                traverseLeft = false;
            }

            if (direction == "R")
            {
                if (traverseRight == true)
                {
                    tempTraversal = _linkedList.TraverseListRight(head, lastTraversalDepth); //lasttraversal also need the direction
                    lastTraversalDepth = _linkedList.TraverseListRight(head, Int32.Parse(traversalDistance));
                    traverseRight = true;
                    traverseLeft = false;

                    if (lastTraversalDepth == 0)
                    {
                        dialInfo.ZeroCount += 1;
                    }


                }

                if (traverseLeft == true)
                {
                    tempTraversal = _linkedList.TraverseListLeft(head, lastTraversalDepth);
                    lastTraversalDepth = _linkedList.TraverseListRight(head, Int32.Parse(traversalDistance));
                    traverseLeft = true;
                    traverseRight = false;

                    if (lastTraversalDepth == 0)
                    {
                        dialInfo.ZeroCount += 1;
                    }

                }

                if (direction == "L")
                {
                    _linkedList.TraverseListLeft(head, 0);

                    if (traverseRight == true)
                    {
                        tempTraversal = _linkedList.TraverseListRight(head, lastTraversalDepth);
                        lastTraversalDepth = _linkedList.TraverseListLeft(head, Int32.Parse(traversalDistance));
                        traverseRight = true;
                        traverseLeft = false;

                        if (lastTraversalDepth == 0)
                        {
                            dialInfo.ZeroCount += 1;
                        }

                    }

                    if (traverseLeft == true)
                    {
                        tempTraversal = _linkedList.TraverseListLeft(head, lastTraversalDepth);
                        lastTraversalDepth = _linkedList.TraverseListLeft(head, Int32.Parse(traversalDistance));
                        traverseLeft = true;
                        traverseRight = false;

                        if (lastTraversalDepth == 0)
                        {
                            dialInfo.ZeroCount += 1;
                        }
                    }
                }
            }
            dialInfo.LastTraversalPosition = tempTraversal;
            dialInfo.IsOnStartPosition = isOnStartPosition;
            dialInfo.TraversalLeft = traverseLeft;
            dialInfo.TraversedRight = traverseRight;


            return dialInfo;
        }
    }
}

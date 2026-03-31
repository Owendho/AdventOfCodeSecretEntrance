using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCodeSecretEntrance
{
    public struct DialInfo
    {
        public DialInfo(int lastTraversalPosition, bool isOnStartPosition, bool traversalRight, bool traversalLeft) 
        {
            LastTraversalPosition = lastTraversalPosition;
            IsOnStartPosition = isOnStartPosition;
            TraversedRight = traversalRight;
            TraversalLeft = traversalLeft;
        }

        public int LastTraversalPosition {  get; set; }
        public bool IsOnStartPosition { get; set; }
        public bool TraversedRight {  get; set; }
        public bool TraversalLeft { get; set; }

        public int ZeroCount { get; set; }


    }
}

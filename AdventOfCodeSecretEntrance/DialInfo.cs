using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCodeSecretEntrance
{
    public struct DialInfo
    {
        //Change contructor
        public DialInfo(int lastTraversalPosition, bool isOnStartPosition, bool traversalRight, bool traversalLeft) 
        {
            LastTraversalPosition = lastTraversalPosition;
            IsOnStartPosition = isOnStartPosition;
            TraversedRight = traversalRight;
            TraversedLeft = traversalLeft;
        }

        private int _lastTraversalPosition = 0;
        public int LastTraversalPosition
        {
            get {  return _lastTraversalPosition; }
            set { _lastTraversalPosition = value; }
        }

        private bool _isOnStartPosition = true;
        public bool IsOnStartPosition 
        {
            get { return _isOnStartPosition; }
            set { _isOnStartPosition = value; }
        }
        private bool _traversedRight = false;
        public bool TraversedRight 
        {
            get { return _traversedRight; }
            set { _traversedRight = value; }
        }
        private bool _traversedLeft = false;
        public bool TraversedLeft
        {
            get { return _traversedLeft; }
            set { _traversedLeft = value; }
        }

        public int ZeroCount { get; set; }


    }
}

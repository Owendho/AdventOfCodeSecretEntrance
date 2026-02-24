using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCodeSecretEntrance
{
    public class NodeRecord
    {
        public int data;
        public NodeRecord nextItem;
        public NodeRecord previousItem;
        public NodeRecord tail;
        public NodeRecord head;
    }
}

using AdventOfCodeSecretEntrance;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace SecretEntranceTests
{
    public class Tests
    {
        private SMLinkedList _linkedList;
        private Dial _dial;
        private DialInfo _dialInfo;
        [SetUp]
        public void Setup()
        {
            _linkedList = new SMLinkedList();
            _dial = new Dial(_linkedList);
            _dialInfo = new DialInfo(0, true, false, false);
        }

        //Test if file is being read
        //Test if it recieves propper direction
        //Test DialAtZeroCount

        //move methods into classes
        //Test linked list methods

        [Test]
        public void DialAtZeroCountTest1()
        {
            //Arrange
            Node head = new Node(0);
            Node current = head;
            string turnDirection = "R";
            string travelDistance = "3";
            

            //Populate linked list
            for (int i = 1; i < 5; i++) 
            {
                current = _linkedList.InsertAtEnd(current, i);
            }

            //Act
            _dialInfo = _dial.DialAtZeroCount(turnDirection, travelDistance, head, _dialInfo);
            //Assert

            using (Assert.EnterMultipleScope())
            {
                Assert.That(_dialInfo.TraversedRight, Is.EqualTo(true));
                Assert.That(_dialInfo.TraversalLeft, Is.EqualTo(false));
                Assert.That(_dialInfo.IsOnStartPosition, Is.EqualTo(false));
                Assert.That(_dialInfo.LastTraversalPosition, Is.EqualTo(3));
            }

            Assert.Pass();
        }
    }
}

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
            for (int i = 1; i < 60; i++) 
            {
                current = _linkedList.InsertAtEnd(current, i);
            }

            //Act
            _dialInfo = _dial.DialAtZeroCount(turnDirection, travelDistance, head, _dialInfo);
            //Assert

            using (Assert.EnterMultipleScope())
            {
                Assert.That(_dialInfo.TraversedRight, Is.EqualTo(true));
                Assert.That(_dialInfo.TraversedLeft, Is.EqualTo(false));
                Assert.That(_dialInfo.IsOnStartPosition, Is.EqualTo(false));
                Assert.That(_dialInfo.LastTraversalPosition, Is.EqualTo(53)); //made the initial traversal go to 3 instead of fifty so it became easier to debug. this should be 6. the assertion will be fifty 53 when intial traversal is changed back to 50
            }

            Assert.Pass();
        }
        
        
        [Test]
        public void DialAtZeroCountTest2OneLoopOfList()
        {
            //Arrange
            Node head = new Node(0);
            Node current = head;
            string turnDirection = "R";
            string travelDistance = "11";


            //Populate linked list. i need to + 1 to the amount of elements that i want to add. the list starts from zero. if i want the list to have nodes with data upto 3 then i need 4 elements since the first element cointains node data zero.
            //this means position 2 on the list has value 1
            for (int i = 1; i < 60; i++) 
            {
                current = _linkedList.InsertAtEnd(current, i);
            }

            //Act
            _dialInfo = _dial.DialAtZeroCount(turnDirection, travelDistance, head, _dialInfo);
            //Assert

            using (Assert.EnterMultipleScope())
            {
                Assert.That(_dialInfo.TraversedRight, Is.EqualTo(true));
                Assert.That(_dialInfo.TraversedLeft, Is.EqualTo(false));
                Assert.That(_dialInfo.IsOnStartPosition, Is.EqualTo(false));
                Assert.That(_dialInfo.LastTraversalPosition, Is.EqualTo(1)); //made the initial traversal go to 3 instead of fifty so it became easier to debug. this should be 6. the assertion will be fifty 53 when intial traversal is changed back to 50
            }

            Assert.Pass();
        }

        [Test]


        public void DialAtZeroCountTestCountZeros()
        {
            //Arrange
            Node head = new Node(0);
            Node current = head;
            string turnDirection = "R";
            string travelDistance = "10";


            //Populate linked list. i need to + 1 to the amount of elements that i want to add. the list starts from zero. if i want the list to have nodes with data upto 3 then i need 4 elements since the first element cointains node data zero.
            //this means position 2 on the list has value 1
            for (int i = 1; i < 60; i++)
            {
                current = _linkedList.InsertAtEnd(current, i);
            }

            //Act
            _dialInfo = _dial.DialAtZeroCount(turnDirection, travelDistance, head, _dialInfo);
            //Assert

            using (Assert.EnterMultipleScope())
            {
                Assert.That(_dialInfo.TraversedRight, Is.EqualTo(true));
                Assert.That(_dialInfo.TraversedLeft, Is.EqualTo(false));
                Assert.That(_dialInfo.IsOnStartPosition, Is.EqualTo(false));
                Assert.That(_dialInfo.LastTraversalPosition, Is.EqualTo(0)); //made the initial traversal go to 3 instead of fifty so it became easier to debug. this should be 6. the assertion will be fifty 53 when intial traversal is changed back to 50
                Assert.That(_dialInfo.ZeroCount, Is.EqualTo(1));
            }

            Assert.Pass();
        }

        //Make tests checking that the direction checks are corrects
        //add tests for rightthenleft method and leftthenright method

    }
}

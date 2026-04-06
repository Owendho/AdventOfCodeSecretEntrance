using AdventOfCodeSecretEntrance;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace SecretEntranceTests
{
    public class Tests
    {
        private Program _program;
        [SetUp]
        public void Setup()
        {
            _program = new Program();
        }

        //Test if file is being read
        //Test if it recieves propper direction
        //Test DialAtZeroCount

        //move methods into classes

        [Test]
        public void DialAtZeroCountTest1()
        {
            //Arrange
            Node head = new Node(0);
            Node current = head;

            //Populate linked list
            for (int i = 1; i < 101; i++) //changed to 3 temporarily
            {

                //current = _program.InsertAtEnd(current, i);
            }

            //Act
            //Assert
            Assert.Pass();
        }
    }
}

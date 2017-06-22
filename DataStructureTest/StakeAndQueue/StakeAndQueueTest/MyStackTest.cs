using DataStructure.StakeAndQueue;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureTest.StakeAndQueue.StakeAndQueueTest
{
    [TestClass]
    public class MyStackTest
    {
        [TestMethod]
        public void StackGetSize()
        {
            int maxSize = 100;
            var myStack = new MyStack(maxSize);
            Assert.AreEqual(100, myStack.GetSize());
        }

        [TestMethod]
        public void StackEmptyandGetCount()
        {
            int maxSize = 100;
            var myStack = new MyStack(maxSize);
            Assert.AreEqual(0, myStack.GetCount());
        }

        [TestMethod]
        public void StackPushGetCount()
        {
            int maxSize = 100;
            var myStack = new MyStack(maxSize);
            myStack.Push(1);

            Assert.AreEqual(1, myStack.GetCount());
        }

        [TestMethod]
        public void StackPush3ItemGetCount()
        {
            int maxSize = 100;
            var myStack = new MyStack(maxSize);
            myStack.Push(1);
            myStack.Push("1");
            myStack.Push("A");

            Assert.AreEqual(3, myStack.GetCount());
        }

        [TestMethod]
        public void StackPush3ItemAndPopGetCount()
        {
            int maxSize = 100;
            var myStack = new MyStack(maxSize);
            myStack.Push(1);
            myStack.Push("1");
            myStack.Push("A");
            var obj = myStack.Pop();
            Assert.AreEqual("A", obj);
            Assert.AreEqual(2, myStack.GetCount());
        }

        [TestMethod]
        public void StackPush3ItemAndPop3GetCountAndIsEmpty()
        {
            int maxSize = 100;
            var myStack = new MyStack(maxSize);
            myStack.Push(1);
            myStack.Push("1");
            myStack.Push("A");
            var obj = myStack.Pop();
            obj = myStack.Pop();
            obj = myStack.Pop();
            Assert.AreEqual(1, obj);
            Assert.AreEqual(true, myStack.IsEmpty());
        }

        [TestMethod]
        public void StackPush10ItemAndIsFull()
        {
            int maxSize = 10;
            var myStack = new MyStack(maxSize);
            myStack.Push("A");
            myStack.Push("B");
            myStack.Push("C");
            myStack.Push("D");
            myStack.Push("E");
            myStack.Push("F");
            myStack.Push("G");
            myStack.Push("H");
            myStack.Push("I");
            myStack.Push("J");
            Assert.AreEqual(true, myStack.IsFull());
        }

        [TestMethod]
        public void StackPush4ItemAndAlreadyFull()
        {
            int maxSize = 3;
            var myStack = new MyStack(maxSize);
            myStack.Push("A");
            myStack.Push("B");
            var bPushSuccess = myStack.Push("C");
            var bPushFail = myStack.Push("D");

            Assert.AreEqual(true, bPushSuccess);
            Assert.AreEqual(false, bPushFail);
        }

        [TestMethod]
        public void StackEmptyAndPop()
        {
            int maxSize = 3;
            var myStack = new MyStack(maxSize);
            var obj = myStack.Pop();
            Assert.IsNull(obj);
        }

        [TestMethod]
        public void StackPush10AndToString()
        {
            int maxSize = 10;
            var myStack = new MyStack(maxSize);
            myStack.Push("A");
            myStack.Push("B");
            myStack.Push("C");
            myStack.Push("D");
            myStack.Push("E");
            myStack.Push("F");
            myStack.Push("G");
            myStack.Push("H");
            myStack.Push("I");
            myStack.Push("J");
            Assert.AreEqual("ABCDEFGHIJ", myStack.ItemToString());
        }

        [TestMethod]
        public void StackPush10AndToString2()
        {
            int maxSize = 10;
            var myStack = new MyStack(maxSize);
            myStack.Push("A");
            myStack.Push("B");
            myStack.Push("C");
            myStack.Push("D");
            myStack.Push("E");
            myStack.Push("F");
            myStack.Push("G");
            myStack.Push("H");
            myStack.Push("I");
            myStack.Push("J");
            myStack.Pop();
            myStack.Pop();
            myStack.Pop();
            Assert.AreEqual("ABCDEFG", myStack.ItemToString());
        }
    }
}
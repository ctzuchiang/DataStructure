using DataStructure.StakeAndQueue;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureTest.StakeAndQueue.StakeAndQueueTest
{
    [TestClass]
    public class MyQueueTest
    {
        [TestMethod]
        public void QueueGetSize()
        {
            int maxSize = 100;
            var myQueue = new MyQueue(maxSize);
            Assert.AreEqual(100, myQueue.GetSize());
        }

        [TestMethod]
        public void QueueEmptyandGetCount()
        {
            int maxSize = 100;
            var myQueue = new MyQueue(maxSize);
            Assert.AreEqual(0, myQueue.GetCount());
        }

        [TestMethod]
        public void QueuePushGetCount()
        {
            int maxSize = 100;
            var myQueue = new MyQueue(maxSize);
            myQueue.Push(1);

            Assert.AreEqual(1, myQueue.GetCount());
        }

        [TestMethod]
        public void QueuePush3ItemGetCount()
        {
            int maxSize = 100;
            var myQueue = new MyQueue(maxSize);
            myQueue.Push(1);
            myQueue.Push("1");
            myQueue.Push("A");

            Assert.AreEqual(3, myQueue.GetCount());
        }

        [TestMethod]
        public void QueuePush3ItemAndPopGetCount()
        {
            int maxSize = 100;
            var myQueue = new MyQueue(maxSize);
            myQueue.Push(1);
            myQueue.Push("1");
            myQueue.Push("A");
            var obj = myQueue.Pop();
            Assert.AreEqual(1, obj);
            Assert.AreEqual(2, myQueue.GetCount());
        }

        [TestMethod]
        public void QueuePush3ItemAndPop3GetCountAndIsEmpty()
        {
            int maxSize = 100;
            var myQueue = new MyQueue(maxSize);
            myQueue.Push(1);
            myQueue.Push("1");
            myQueue.Push("A");
            var obj = myQueue.Pop();
            obj = myQueue.Pop();
            obj = myQueue.Pop();
            Assert.AreEqual("A", obj);
            Assert.AreEqual(true, myQueue.IsEmpty());
        }

        [TestMethod]
        public void QueuePush10ItemAndIsFull()
        {
            int maxSize = 10;
            var myQueue = new MyQueue(maxSize);
            myQueue.Push("A");
            myQueue.Push("B");
            myQueue.Push("C");
            myQueue.Push("D");
            myQueue.Push("E");
            myQueue.Push("F");
            myQueue.Push("G");
            myQueue.Push("H");
            myQueue.Push("I");
            myQueue.Push("J");
            Assert.AreEqual(true, myQueue.IsFull());
        }

        [TestMethod]
        public void QueuePush4ItemAndAlreadyFull()
        {
            int maxSize = 3;
            var myQueue = new MyQueue(maxSize);
            myQueue.Push("A");
            myQueue.Push("B");
            var bPushSuccess = myQueue.Push("C");
            var bPushFail = myQueue.Push("D");

            Assert.AreEqual(true, bPushSuccess);
            Assert.AreEqual(false, bPushFail);
        }

        [TestMethod]
        public void QueueEmptyAndPop()
        {
            int maxSize = 3;
            var myQueue = new MyQueue(maxSize);
            var obj = myQueue.Pop();
            Assert.IsNull(obj);
        }

        [TestMethod]
        public void QueuePush10ItemAndToString()
        {
            int maxSize = 10;
            var myQueue = new MyQueue(maxSize);
            myQueue.Push("A");
            myQueue.Push("B");
            myQueue.Push("C");
            myQueue.Push("D");
            myQueue.Push("E");
            myQueue.Push("F");
            myQueue.Push("G");
            myQueue.Push("H");
            myQueue.Push("I");
            myQueue.Push("J");
            Assert.AreEqual("ABCDEFGHIJ", myQueue.ItemToString());
        }

        [TestMethod]
        public void QueuePush10ItemAndToString2()
        {
            int maxSize = 10;
            var myQueue = new MyQueue(maxSize);
            myQueue.Push("A");
            myQueue.Push("B");
            myQueue.Push("C");
            myQueue.Push("D");
            myQueue.Push("E");
            myQueue.Push("F");
            myQueue.Push("G");
            myQueue.Push("H");
            myQueue.Push("I");
            myQueue.Push("J");
            myQueue.Pop();
            myQueue.Pop();
            myQueue.Pop();
            Assert.AreEqual("DEFGHIJ", myQueue.ItemToString());
        }
    }
}
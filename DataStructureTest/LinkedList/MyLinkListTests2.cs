using DataStructure.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureTest.LinkedList
{
    [TestClass]
    public class MyLinkListTests2
    {
        [TestMethod]
        public void InvertTest()
        {
            var list = new MyLinkList();
            list.Add("A");
            list.Add("B");
            list.Add("C");
            list.Invert();
            Assert.AreEqual("CBA", list.ToString());
        }

        [TestMethod]
        public void ConcatenateTest()
        {
            var list = new MyLinkList();
            list.Add("A");
            list.Add("B");
            list.Add("C");
            var list2 = new MyLinkList();
            list2.Add("D");
            list2.Add("E");
            list2.Add("F");
            list2.Concatenate(list);
            Assert.AreEqual("DEFABC", list2.ToString());
        }

        [TestMethod]
        public void RemoveAllTest()
        {
            var list = new MyLinkList();
            list.Add("A");
            list.Add("B");
            list.Add("C");
            list.RemoveAll();
            Assert.AreEqual("", list.ToString());
        }

        [TestMethod]
        public void IsContainTestTrue()
        {
            var list = new MyLinkList();
            list.Add("A");
            list.Add("B");
            list.Add("C");
            Assert.AreEqual(true, list.IsContain("B"));
        }

        [TestMethod]
        public void IsContainTestFalse()
        {
            var list = new MyLinkList();
            list.Add("A");
            list.Add("B");
            list.Add("C");
            Assert.AreEqual(false, list.IsContain("D"));
        }
    }
}

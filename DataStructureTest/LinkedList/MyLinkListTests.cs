using DataStructure.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureTest.LinkedList
{
	[TestClass]
	public class MyLinkListTests
	{
		[TestMethod]
		public void AddTest()
		{
			var list = new MyLinkList();
			list.Add("A");
			list.Add("B");
			list.Add("C");
			Assert.AreEqual("ABC", list.ToString());
		}

		[TestMethod]
		public void AddAtStartTest()
		{
			var list = new MyLinkList();
			list.AddAtStart("A");
			list.AddAtStart("B");
			list.AddAtStart("C");
			Assert.AreEqual("CBA", list.ToString());
		}

		[TestMethod]
		public void RemoveFromStartTest()
		{
			var list = new MyLinkList();
			list.AddAtStart("A");
			list.AddAtStart("B");
			list.AddAtStart("C");
			list.RemoveFirst();
			Assert.AreEqual("BA", list.ToString());
		}

		[TestMethod]
		public void RemoveLastTest()
		{
			var list = new MyLinkList();
			list.AddAtStart("A");
			list.AddAtStart("B");
			list.AddAtStart("C");
			list.RemoveLast();
			Assert.AreEqual("CB", list.ToString());
		}

		[TestMethod]
		public void RemoveTest()
		{
			var list = new MyLinkList();
			list.Add("A");
			list.Add("B");
			list.Add("C");
			list.Add("D");
			list.Add("E");
			list.Remove("C");
			list.Remove("D");
			Assert.AreEqual("ABE", list.ToString());
		}

		[TestMethod]
		public void CountTest()
		{
			var list = new MyLinkList();
			list.Add("A");
			list.Add("B");
			list.Add("C");
			list.Add("D");
			list.Add("E");
			list.Remove("C");
			list.Remove("D");
			Assert.AreEqual(3, list.Count);
		}
	}
}
using System;
using DataStructure.InterviewQuestion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureTest.InterviewQuestion
{
    [TestClass]
    public class StarTreesTest
    {
        [TestMethod]
        public void StarTree_Test()
        {
            Console.WriteLine("StarTree_1\n");
            new StarTrees().StarTree_1(5);
            Console.WriteLine("\nStarTree_2\n");
            new StarTrees().StarTree_2(5);
        }
    }
}

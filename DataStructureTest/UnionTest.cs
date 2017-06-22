using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureTest
{
    [TestClass]
    public class UnionTest
    {
        [TestMethod]
        public void Union_test1()
        {
            int[] union1 = new[] { 0, 1 ,0};
            int[] union2 = new[] { 2, 3 ,0};

            IEnumerable<int> union = union1.Union(union2);

            foreach (int num in union)
            {
                Console.Write("{0} ", num);
            }
        }
    }
}

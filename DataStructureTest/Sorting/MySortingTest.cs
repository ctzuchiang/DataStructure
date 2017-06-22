using System;
using System.Collections;
using System.Diagnostics;
using System.Linq;
using DataStructure.Sorting;
using ExpectedObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureTest.Sorting
{
    [TestClass]
    public class MySortingTest
    {
        private int[] _Data;
        private const int _DataQuantity = 1000;
        
        [TestInitialize]
        public void SetUp()
        {
            Random rnd = new Random();

            _Data = new int[_DataQuantity];
            for (int i = 0; i < _DataQuantity; i++)
            {
                _Data[i] = rnd.Next(0, 5000);
            }
        }

        [TestMethod]
        public void SortingTest()
        {
            var expected = _Data.OrderBy(i => i).ToArray();

            Stopwatch watch = new Stopwatch();

            watch.Start();
            var actual = new MySorting().Sorting(_Data);
            watch.Stop();

            Console.WriteLine(watch.Elapsed);

            expected.ToExpectedObject().ShouldEqual(actual);
        }
    }
}

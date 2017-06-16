using System.Collections.Generic;
using DataStructure.FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureTest.FizzBuzz
{
    [TestClass]
    public class FizzBuzzTest
    {
        private List<string> _ExpectedList;
        private FizzBuzzC _FizzBuzzC;

        public void SetUp()
        {
            _FizzBuzzC = new FizzBuzzC();
            _ExpectedList = new List<string>
            {
                "1",
                "2",
                "Fizz",
                "4",
                "Buzz",
                "Fizz",
                "7",
                "8",
                "Fizz",
                "Buzz",
                "11",
                "Fizz",
                "13",
                "14",
                "FizzBuzz"
            };
        }

        [TestMethod]
        public void FizzBuzz_3_Test()
        {
            SetUp();
            Assert.AreEqual(_FizzBuzzC.FizzBuzz_3(15), _ExpectedList.ToString());
        }

        [TestMethod]
        public void GetModString_Test()
        {
            SetUp();
            Assert.AreEqual(_FizzBuzzC.GetModString(1), "1");
            Assert.AreEqual(_FizzBuzzC.GetModString(3), "Fizz");
            Assert.AreEqual(_FizzBuzzC.GetModString(5), "Buzz");
            Assert.AreEqual(_FizzBuzzC.GetModString(15), "FizzBuzz");
        }
    }
}

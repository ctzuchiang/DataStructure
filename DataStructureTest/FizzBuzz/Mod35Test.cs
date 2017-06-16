using System.Collections.Generic;
using DataStructure.FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureTest.FizzBuzz
{
    [TestClass]
    public class Mod35Test
    {
        private List<string> _ExpectedList;
        private Mod35 _Mod35;

        public void SetUp()
        {
            _Mod35 = new Mod35();
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
        public void FizzBuzz_1_Test()
        {
            SetUp();
            Assert.AreEqual(_Mod35.FizzBuzz_1(15), _ExpectedList.ToString());
        }

        [TestMethod]
        public void FizzBuzz_2_Test()
        {
            SetUp();
            Assert.AreEqual(_Mod35.FizzBuzz_2(15), _ExpectedList.ToString());
        }
    }
}

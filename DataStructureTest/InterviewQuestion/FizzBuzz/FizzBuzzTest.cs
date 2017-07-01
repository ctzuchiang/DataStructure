using System;
using System.Collections.Generic;
using System.Diagnostics;
using DataStructure.InterviewQuestion.FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpectedObjects;

namespace DataStructureTest.InterviewQuestion.FizzBuzz
{
    [TestClass]
    public class FizzBuzzTest
    {
        private IEnumerable<object> _ExpectedList;
        private FizzBuzzService _FizzBuzzService;

        [TestInitialize]
        public void SetUp()
        {
            _FizzBuzzService = new FizzBuzzService();
            _ExpectedList = new object[]
            {
                1,
                2,
                "\"3\"",
                4,
                "\"5\"",
                "\"3\"",
                "\"7\"",
                8,
                "\"3\"",
                "\"5\"",
                11,
                "\"3\"",
                13,
                "\"7\"",
                "\"35\"",
                16,
                17,
                "\"3\"",
                19,
                "\"5\"",
                "\"37\"",
            };
        }

        [TestMethod]
        public void FizzBuzz_string_Test()
        {
            var actual = _FizzBuzzService.FizzBuzz_string(21, new[] { 3, 5, 7 });
            _ExpectedList.ToExpectedObject().ShouldEqual(actual);
        }

        [TestMethod]
        public void FizzBuzz_stringBuilder_Test()
        {
            var actual = _FizzBuzzService.FizzBuzz_stringBuilder(21, new[] { 3, 5, 7 });
            _ExpectedList.ToExpectedObject().ShouldEqual(actual);
        }

        [TestMethod]
        public void FizzBuzz_Performance_Test()
        {
            Stopwatch watch1 = new Stopwatch();
            watch1.Start();
            Action act1 = () => _FizzBuzzService.FizzBuzz_string(90000000, new[] { 3, 5, 7, 11, 13, 17, 19, 23, 29 });
            watch1.Stop();
            Console.WriteLine("String       : {0}", watch1.Elapsed);

            Stopwatch watch2 = new Stopwatch();
            watch2.Start();
            Action act2 = () => _FizzBuzzService.FizzBuzz_stringBuilder(90000000, new[] { 3, 5, 7, 11, 13, 17, 19, 23, 29 });
            watch2.Stop();
            Console.WriteLine("StringBuilder: {0}", watch2.Elapsed);
        }

    }
}
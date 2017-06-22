using System;
using System.Diagnostics;
using NUnit.Framework;
using ExpectedObjects;

namespace DataStructureTest.MyMath
{
    [TestFixture()]
    public class MyMathTests
    {
        private DataStructure.Math.MyMath _Target;

        [SetUp]
        public void SetUp()
        {
            _Target = new DataStructure.Math.MyMath();
        }

        [TestCase(3, 5, ExpectedResult = 1, TestName = "3_5")]
        [TestCase(5, 10, ExpectedResult = 5, TestName = "5_10")]
        [TestCase(25, 10, ExpectedResult = 5, TestName = "25_10")]
        [TestCase(1071, 462, ExpectedResult = 21, TestName = "1071_462")]
        [TestCase(990301070, 5120465, ExpectedResult = 5, TestName = "90301070_120465")]
        public int GCD(int a, int b)
        {
            return _Target.GCD(a, b);
        }

        [TestCase(3, 5, ExpectedResult = 1, TestName = "3_5")]
        [TestCase(5, 10, ExpectedResult = 5, TestName = "5_10")]
        [TestCase(25, 10, ExpectedResult = 5, TestName = "25_10")]
        [TestCase(1071, 462, ExpectedResult = 21, TestName = "1071_462")]
        [TestCase(990301070, 5120465, ExpectedResult = 5, TestName = "90301070_120465")]
        public int GCD1(int a, int b)
        {
            return _Target.GCD1(a, b);
        }

        [TestCase(3, 5, ExpectedResult = 1, TestName = "3_5")]
        [TestCase(5, 10, ExpectedResult = 5, TestName = "5_10")]
        [TestCase(25, 10, ExpectedResult = 5, TestName = "25_10")]
        [TestCase(1071, 462, ExpectedResult = 21, TestName = "1071_462")]
        [TestCase(990301070, 5120465, ExpectedResult = 5, TestName = "90301070_120465")]
        public int GCD_Recursive(int a, int b)
        {
            return _Target.GCD_Recursive(a, b);
        }

        [TestCase(3, 5, ExpectedResult = 1, TestName = "3_5")]
        [TestCase(5, 10, ExpectedResult = 5, TestName = "5_10")]
        [TestCase(25, 10, ExpectedResult = 5, TestName = "25_10")]
        [TestCase(1071, 462, ExpectedResult = 21, TestName = "1071_462")]
        [TestCase(990301070, 5120465, ExpectedResult = 5, TestName = "90301070_120465")]
        public int GCD1_Recursive(int a, int b)
        {
            return _Target.GCD1_Recursive(a, b);
        }

        [Test]
        public void PrimeTest()
        {
            Stopwatch watch = new Stopwatch();
            
            var expect = new[]
            {
                2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 
                59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113,
                127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181,
                191, 193, 197, 199, 211, 223, 227, 229, 233, 239, 241, 251,
                257, 263, 269, 271, 277, 281, 283, 293, 307, 311, 313, 317, 
                331, 337, 347, 349, 353, 359, 367, 373, 379, 383, 389, 397, 
                401, 409, 419, 421, 431, 433, 439, 443, 449, 457, 461, 463, 
                467, 479, 487, 491, 499, 503, 509, 521, 523, 541, 547, 557, 
                563, 569, 571, 577, 587, 593, 599, 601, 607, 613, 617, 619, 
                631, 641, 643, 647, 653, 659, 661, 673, 677, 683, 691, 701, 
                709, 719, 727, 733, 739, 743, 751, 757, 761, 769, 773, 787, 
                797, 809, 811, 821, 823, 827, 829, 839, 853, 857, 859, 863, 
                877, 881, 883, 887, 907, 911, 919, 929, 937, 941, 947, 953, 
                967, 971, 977, 983, 991, 997
            };
            watch.Start();
            var actual = _Target.Prime(1000);
            watch.Stop();
            Console.WriteLine(watch.Elapsed);
            expect.ToExpectedObject().ShouldEqual(actual);
        }

        [Test]
        public void Prime2Test()
        {
            Stopwatch watch = new Stopwatch();
            var expect = new[]
            {
                2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 
                59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113,
                127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181,
                191, 193, 197, 199, 211, 223, 227, 229, 233, 239, 241, 251,
                257, 263, 269, 271, 277, 281, 283, 293, 307, 311, 313, 317, 
                331, 337, 347, 349, 353, 359, 367, 373, 379, 383, 389, 397, 
                401, 409, 419, 421, 431, 433, 439, 443, 449, 457, 461, 463, 
                467, 479, 487, 491, 499, 503, 509, 521, 523, 541, 547, 557, 
                563, 569, 571, 577, 587, 593, 599, 601, 607, 613, 617, 619, 
                631, 641, 643, 647, 653, 659, 661, 673, 677, 683, 691, 701, 
                709, 719, 727, 733, 739, 743, 751, 757, 761, 769, 773, 787, 
                797, 809, 811, 821, 823, 827, 829, 839, 853, 857, 859, 863, 
                877, 881, 883, 887, 907, 911, 919, 929, 937, 941, 947, 953, 
                967, 971, 977, 983, 991, 997
            };

            watch.Start();
            var actual = _Target.PrimeList(1000);
            watch.Stop();
            Console.WriteLine(watch.Elapsed);

            expect.ToExpectedObject().ShouldEqual(actual);
        }
    }
}

using DataStructure;
using NUnit.Framework;

namespace DataStructureTest
{
    [TestFixture]
    public class PalindromTests
    {
        [TestCase("A", ExpectedResult = true, TestName = "input_A")]
        [TestCase("AA", ExpectedResult = true, TestName = "input_AA")]
        [TestCase("ABA", ExpectedResult = true, TestName = "input_ABA")]
        [TestCase("ABCDEFFEDCBA", ExpectedResult = true, TestName = "input_ABCDEFFEDCBA")]
        [TestCase("ABCDEF9FEDCBA", ExpectedResult = true, TestName = "input_ABCDEF9FEDCBA")]
        public bool IsPalindromTest_shold_be_true(string input)
        {
            return new Palindrom().IsPalindrom(input);
        }

        [TestCase("AB", ExpectedResult = false, TestName = "input_AB")]
        [TestCase("ABC", ExpectedResult = false, TestName = "input_ABC")]
        public bool IsPalindromTest_shold_be_false(string input)
        {
            return new Palindrom().IsPalindrom(input);
        }

        [TestCase("A", ExpectedResult = true, TestName = "input_A")]
        [TestCase("AA", ExpectedResult = true, TestName = "input_AA")]
        [TestCase("ABA", ExpectedResult = true, TestName = "input_ABA")]
        [TestCase("ABCDEFFEDCBA", ExpectedResult = true, TestName = "input_ABCDEFFEDCBA")]
        [TestCase("ABCDEF9FEDCBA", ExpectedResult = true, TestName = "input_ABCDEF9FEDCBA")]
        public bool IsPalindrom2Test_shold_be_true(string input)
        {
            return new Palindrom().IsPalindrom2(input);
        }

        [TestCase("AB", ExpectedResult = false, TestName = "input_AB")]
        [TestCase("ABC", ExpectedResult = false, TestName = "input_ABC")]
        public bool IsPalindrom2Test_shold_be_false(string input)
        {
            return new Palindrom().IsPalindrom2(input);
        }

        [TestCase("A", ExpectedResult = true, TestName = "input_A")]
        [TestCase("AA", ExpectedResult = true, TestName = "input_AA")]
        [TestCase("ABA", ExpectedResult = true, TestName = "input_ABA")]
        [TestCase("ABCDEFFEDCBA", ExpectedResult = true, TestName = "input_ABCDEFFEDCBA")]
        [TestCase("ABCDEF9FEDCBA", ExpectedResult = true, TestName = "input_ABCDEF9FEDCBA")]
        public bool IsPalindrom3Test_shold_be_true(string input)
        {
            return new Palindrom().IsPalindrom3(input);
        }

        [TestCase("AB", ExpectedResult = false, TestName = "input_AB")]
        [TestCase("ABC", ExpectedResult = false, TestName = "input_ABC")]
        public bool IsPalindrom3Test_shold_be_false(string input)
        {
            return new Palindrom().IsPalindrom3(input);
        }

        [TestCase("A", ExpectedResult = true, TestName = "input_A")]
        [TestCase("AA", ExpectedResult = true, TestName = "input_AA")]
        [TestCase("ABA", ExpectedResult = true, TestName = "input_ABA")]
        [TestCase("ABCDEFFEDCBA", ExpectedResult = true, TestName = "input_ABCDEFFEDCBA")]
        [TestCase("ABCDEF9FEDCBA", ExpectedResult = true, TestName = "input_ABCDEF9FEDCBA")]
        public bool IsPalindrom4Test_shold_be_true(string input)
        {
            return new Palindrom().IsPalindrom4(input);
        }

        [TestCase("AB", ExpectedResult = false, TestName = "input_AB")]
        [TestCase("ABC", ExpectedResult = false, TestName = "input_ABC")]
        public bool IsPalindrom4Test_shold_be_false(string input)
        {
            return new Palindrom().IsPalindrom4(input);
        }

    }
}
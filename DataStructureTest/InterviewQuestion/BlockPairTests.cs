using DataStructure.InterviewQuestion;
using NUnit.Framework;

namespace DataStructureTest.InterviewQuestion
{
    [TestFixture]
    public class BlockPairTests
    {
        [TestCase("AA", ExpectedResult = true, TestName = "BlockPairTest_AA")]
        [TestCase("AABB", ExpectedResult = true, TestName = "BlockPairTest_AABB")]
        [TestCase("ABBA", ExpectedResult = true, TestName = "BlockPairTest_ABBA")]
        [TestCase("AABBCC", ExpectedResult = true, TestName = "BlockPairTest_AABBCC")]
        [TestCase("ABBCCA", ExpectedResult = true, TestName = "BlockPairTest_ABBCCA")]
        [TestCase("ABCCBA", ExpectedResult = true, TestName = "BlockPairTest_ABCCBA")]
        [TestCase("AABCCB", ExpectedResult = true, TestName = "BlockPairTest_AABCCB")]
        public bool BlockPairTest_should_be_true(string input)
        {
            return new BlockPair().IsPair(input);
        }

        [TestCase("A", ExpectedResult = false, TestName = "BlockPairTest_A")]
        [TestCase("AB", ExpectedResult = false, TestName = "BlockPairTest_AB")]
        [TestCase("ABCBA", ExpectedResult = false, TestName = "BlockPairTest_ABCBA")]
        [TestCase("ABCBCA", ExpectedResult = false, TestName = "BlockPairTest_ABCBCA")]
        public bool BlockPairTest_should_be_false(string input)
        {
            return new BlockPair().IsPair(input);
        }


    }
}
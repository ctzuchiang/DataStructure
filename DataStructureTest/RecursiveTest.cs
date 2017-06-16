using DataStructure;
using NUnit.Framework;

namespace DataStructureTest
{
    [TestFixture]
    public class RecursiveTest
    {
        [TestCase(3, ExpectedResult = 6, TestName = "BarTest_n_is_3")]
        [TestCase(4, ExpectedResult = 24, TestName = "BarTest_n_is_4")]
        public int BarTest_should_equal(int n)
        {
            return new Recursive().Bar(n);
        }
    }
}

using DataStructure.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyLinkListTests
{
    [Ignore]
    [TestClass]
    public class EquivalenceTest
    {
        [TestMethod]
        public void EquivalenceTest1Equivalent2()
        {
            var equivalence = new MyEquivalence(10);
            equivalence.SetEquivalence(1, 2);
            equivalence.RunEquivalence();
            Assert.AreEqual(1, equivalence.GetEquivalentSetsCount());
        }

        [TestMethod]
        public void EquivalenceTest1Equivalent2And2Equivalent3()
        {
            var equivalence = new MyEquivalence(10);
            equivalence.SetEquivalence(1, 2);
            equivalence.SetEquivalence(2, 3);
            equivalence.RunEquivalence();
            Assert.AreEqual(1, equivalence.GetEquivalentSetsCount());
        }

        [TestMethod]
        public void GetEquivalenceSetTest1Equivalent2()
        {
            var equivalence = new MyEquivalence(10);
            equivalence.SetEquivalence(1, 2);
            equivalence.RunEquivalence();
            Assert.AreEqual("{1,2}", equivalence.GetEquivalentSets(equivalence.GetEquivalentSetsCount() - 1));
        }

        [TestMethod]
        public void GetEquivalenceSetTest1Equivalent2Anbd3()
        {
            var equivalence = new MyEquivalence(10);
            equivalence.SetEquivalence(1, 2);
            equivalence.SetEquivalence(2, 3);
            equivalence.RunEquivalence();
            Assert.AreEqual("{1,2,3}", equivalence.GetEquivalentSets(equivalence.GetEquivalentSetsCount() - 1));
        }

        [TestMethod]
        public void GetEquivalenceSetTest1Equivalent2And3Equivalent4()
        {
            var equivalence = new MyEquivalence(10);
            equivalence.SetEquivalence(1, 2);
            equivalence.SetEquivalence(3, 4);
            equivalence.RunEquivalence();
            Assert.AreEqual("{1,2}", equivalence.GetEquivalentSets(0));
            Assert.AreEqual("{3,4}", equivalence.GetEquivalentSets(1));
        }

        [TestMethod]
        public void GetEquivalenceSetTestUseSample()
        {
            var equivalence = new MyEquivalence(20);
            equivalence.SetEquivalence(0, 4);
            equivalence.SetEquivalence(3, 1);
            equivalence.SetEquivalence(6, 10);
            equivalence.SetEquivalence(8, 9);
            equivalence.SetEquivalence(7, 4);
            equivalence.SetEquivalence(6, 8);
            equivalence.SetEquivalence(3, 5);
            equivalence.SetEquivalence(2, 11);
            equivalence.SetEquivalence(11, 0);
            equivalence.RunEquivalence();
            Assert.AreEqual("{0,2,4,7,11}", equivalence.GetEquivalentSets(0));
            Assert.AreEqual("{1,3,5}", equivalence.GetEquivalentSets(1));
            Assert.AreEqual("{6,8,9,10}", equivalence.GetEquivalentSets(2));
        }
    }
}

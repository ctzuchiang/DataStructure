using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureTest.Polynomial
{
    [TestClass]
    public class PolynomialTest
    {

        [TestMethod]
        public void TestCoef()
        {
            DataStructure.Polynomial.Polynomial p = new DataStructure.Polynomial.Polynomial();
            p.SetItem(20, 3);
            p.SetItem(5, 2);
            p.SetItem(0, 4);

            Assert.AreEqual(3, p.Coef(20));
            Assert.AreEqual(2, p.Coef(5));
            Assert.AreEqual(4, p.Coef(0));
        }

        [TestMethod]
        public void TestLeadExp()
        {
            DataStructure.Polynomial.Polynomial p = new DataStructure.Polynomial.Polynomial();
            p.SetItem(20, 3);
            p.SetItem(5, 2);
            p.SetItem(0, 4);

            Assert.AreEqual(20, p.LeadExp());
        }

        [TestMethod]
        public void AddTest()
        {
            DataStructure.Polynomial.Polynomial p = new DataStructure.Polynomial.Polynomial();
            p.SetItem(20, 3);
            p.SetItem(5, 2);
            p.SetItem(0, 4);

            DataStructure.Polynomial.Polynomial p2 = new DataStructure.Polynomial.Polynomial();
            p2.SetItem(4, 1);
            p2.SetItem(3, 10);
            p2.SetItem(2, 3);
            p2.SetItem(0, 1);

            DataStructure.Polynomial.Polynomial polyAdd = p.Add(p2);

            Assert.AreEqual(3, polyAdd.Coef(20));
            Assert.AreEqual(2, polyAdd.Coef(5));
            Assert.AreEqual(1, polyAdd.Coef(4));
            Assert.AreEqual(10, polyAdd.Coef(3));
            Assert.AreEqual(3, polyAdd.Coef(2));
            Assert.AreEqual(5, polyAdd.Coef(0));
        }

        [TestMethod]
        public void AddTestSameValue()
        {
            DataStructure.Polynomial.Polynomial p = new DataStructure.Polynomial.Polynomial();
            p.SetItem(20, 3);
            p.SetItem(5, 2);
            p.SetItem(0, 4);

            DataStructure.Polynomial.Polynomial p2 = new DataStructure.Polynomial.Polynomial();
            p2.SetItem(20, 3);
            p2.SetItem(5, 2);
            p2.SetItem(0, 4);

            DataStructure.Polynomial.Polynomial polyAdd = p.Add(p2);

            Assert.AreEqual(6, polyAdd.Coef(20));
            Assert.AreEqual(4, polyAdd.Coef(5));
            Assert.AreEqual(8, polyAdd.Coef(0));
        }

        [TestMethod]
        public void MultTest1()
        {
            DataStructure.Polynomial.Polynomial p = new DataStructure.Polynomial.Polynomial();
            p.SetItem(1, 3);
            p.SetItem(0, 4);

            DataStructure.Polynomial.Polynomial p2 = new DataStructure.Polynomial.Polynomial();
            p2.SetItem(1, 3);
            p2.SetItem(0, 4);

            DataStructure.Polynomial.Polynomial polyAdd = p.Mult(p2);

            Assert.AreEqual(9, polyAdd.Coef(2));
            Assert.AreEqual(24, polyAdd.Coef(1));
            Assert.AreEqual(16, polyAdd.Coef(0));
        }

        [TestMethod]
        public void MultTest2()
        {
            DataStructure.Polynomial.Polynomial p = new DataStructure.Polynomial.Polynomial();
            p.SetItem(20, 3);
            p.SetItem(5, 2);
            p.SetItem(0, 4);

            DataStructure.Polynomial.Polynomial p2 = new DataStructure.Polynomial.Polynomial();
            p2.SetItem(4, 1);
            p2.SetItem(3, 10);
            p2.SetItem(2, 3);
            p2.SetItem(0, 1);

            DataStructure.Polynomial.Polynomial polyAdd = p.Mult(p2);

            Assert.AreEqual(3, polyAdd.Coef(24));
            Assert.AreEqual(30, polyAdd.Coef(23));
            Assert.AreEqual(9, polyAdd.Coef(22));
            Assert.AreEqual(3, polyAdd.Coef(20));
            Assert.AreEqual(2, polyAdd.Coef(9));
            Assert.AreEqual(20, polyAdd.Coef(8));
            Assert.AreEqual(6, polyAdd.Coef(7));
            Assert.AreEqual(2, polyAdd.Coef(5));
            Assert.AreEqual(4, polyAdd.Coef(4));
            Assert.AreEqual(40, polyAdd.Coef(3));
            Assert.AreEqual(12, polyAdd.Coef(2));
            Assert.AreEqual(4, polyAdd.Coef(0));
        }

        [TestMethod]
        public void EvalXequal0()
        {
            DataStructure.Polynomial.Polynomial p = new DataStructure.Polynomial.Polynomial();
            p.SetItem(4, 1);
            p.SetItem(3, 10);
            p.SetItem(2, 3);
            p.SetItem(0, 1);

            Assert.AreEqual(1, p.Eval(0));
        }

        [TestMethod]
        public void EvalXequal1()
        {
            DataStructure.Polynomial.Polynomial p = new DataStructure.Polynomial.Polynomial();
            p.SetItem(4, 1);
            p.SetItem(3, 10);
            p.SetItem(2, 3);
            p.SetItem(0, 1);

            Assert.AreEqual(15, p.Eval(1));
        }

        [TestMethod]
        public void EvalXequal2()
        {
            DataStructure.Polynomial.Polynomial p = new DataStructure.Polynomial.Polynomial();
            p.SetItem(4, 1);
            p.SetItem(3, 10);
            p.SetItem(2, 3);
            p.SetItem(0, 1);

            Assert.AreEqual(109, p.Eval(2));
        }
    }
}

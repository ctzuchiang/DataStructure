using DataStructure.InfixToPostfix;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureTest
{
    [TestClass]
    public class InfixToPostfixTest
    {
        [TestMethod]
        public void InfixToPostfixTest1()
        {
            var input = "A+B";
            var expected = "AB+";

            var itp = new InfixToPostfix();
            var output = itp.ToPostfix(input);
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void InfixToPostfixTest1_1()
        {
            var input = "A+B+C";
            var expected = "AB+C+";

            var itp = new InfixToPostfix();
            var output = itp.ToPostfix(input);
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void InfixToPostfixTest2()
        {
            var input = "A+B*C";
            var expected = "ABC*+";

            var itp = new InfixToPostfix();
            var output = itp.ToPostfix(input);
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void InfixToPostfixTest3()
        {
            var input = "A+B*C+D";
            var expected = "ABC*+D+";

            var itp = new InfixToPostfix();
            var output = itp.ToPostfix(input);
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void InfixToPostfixTest4()
        {
            var input = "A*B+C*D";
            var expected = "AB*CD*+";

            var itp = new InfixToPostfix();
            var output = itp.ToPostfix(input);
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void InfixToPostfixTest5()
        {
            var input = "A+B+C+D";
            var expected = "AB+C+D+";

            var itp = new InfixToPostfix();
            var output = itp.ToPostfix(input);
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void InfixToPostfixTest6()
        {
            var input = "a+b*c-d";
            var expected = "abc*+d-";

            var itp = new InfixToPostfix();
            var output = itp.ToPostfix(input);
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void InfixToPostfixTest7()
        {
            var input = "a+b*d+c/d";
            var expected = "abd*+cd/+";

            var itp = new InfixToPostfix();
            var output = itp.ToPostfix(input);
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void InfixToPostfixEvalTest1()
        {
            var input = "2+3";
            var expected = 5;

            var itp = new InfixToPostfix();
            var output = itp.Eval(input);
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void InfixToPostfixEvalTest2()
        {
            var input = "2+3*2";
            var expected = 8;

            var itp = new InfixToPostfix();
            var output = itp.Eval(input);
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void InfixToPostfixEvalTest3()
        {
            var input = "2+3*2+1";
            var expected = 9;

            var itp = new InfixToPostfix();
            var output = itp.Eval(input);
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void InfixToPostfixEvalTest4()
        {
            var input = "2*3+2*1";
            var expected = 8;

            var itp = new InfixToPostfix();
            var output = itp.Eval(input);
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void InfixToPostfixEvalTest5()
        {
            var input = "2+3+2+1";
            var expected = 8;

            var itp = new InfixToPostfix();
            var output = itp.Eval(input);
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void InfixToPostfixEvalTest6()
        {
            var input = "2+3*2-4";
            var expected = 4;

            var itp = new InfixToPostfix();
            var output = itp.Eval(input);
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void InfixToPostfixEvalTest7()
        {
            var input = "1+2*3+4/2";
            var expected = 9;

            var itp = new InfixToPostfix();
            var output = itp.Eval(input);
            Assert.AreEqual(expected, output);
        }
    }
}
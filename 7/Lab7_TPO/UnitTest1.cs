using lab7;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Lab7_TPO
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            Assert.AreEqual(4.0, Calculator.Program.Calculator.Add(2.0, 2.0));
        }

        [TestMethod]
        public void TestSub()
        {
            Assert.AreEqual(3.0, Calculator.Program.Calculator.Sub(5.0, 2.0));
        }

        [TestMethod]
        public void TestMult()
        {
            Assert.AreEqual(6.0, Calculator.Program.Calculator.Mult(2.0, 3.0));
        }

        [TestMethod]
        public void TestDiv()
        {
            Assert.AreEqual(5.0, Calculator.Program.Calculator.Div(10.0, 2.0));
        }

        [TestMethod]
        public void TestPow()
        {
            Assert.AreEqual(8.0, Calculator.Program.Calculator.Pow(2.0, 3));
        }

        [TestMethod]
        public void TestPowWithNegativeDegree()
        {
            Assert.AreEqual(0.125, Calculator.Program.Calculator.Pow(2.0, -3));
        }

        [TestMethod]
        public void TestFindSquareRoot()
        {
            Assert.AreEqual(2.0, Calculator.Program.Calculator.FindSquareRoot(4.0));
        }

        [TestMethod]
        public void TestFindSquareRootOfZero()
        {
            Assert.AreEqual(0.0, Calculator.Program.Calculator.FindSquareRoot(0.0));
        }

        [TestMethod]
        public void TestFindSquareRootWithCustomEpsilon()
        {
            Assert.IsNotNull(Calculator.Program.Calculator.FindSquareRoot(25.0, 0.1));
        }

        [TestMethod]
        public void TestDivByZero()
        {
            Assert.IsNotNull(Calculator.Program.Calculator.Div(5.0, 0.0));
        }
    }

}

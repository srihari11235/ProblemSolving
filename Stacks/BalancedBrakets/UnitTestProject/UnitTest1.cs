using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBrakets;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            var bracket = new Bracket();
            var result = bracket.ValidateInput("[]");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test2()
        {
            var bracket = new Bracket();
            var result = bracket.ValidateInput("[{}]");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test3()
        {
            var bracket = new Bracket();
            var result = bracket.ValidateInput("[{()}]");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test4()
        {
            var bracket = new Bracket();
            var result = bracket.ValidateInput("[{(()}]");

            Assert.IsFalse(result);
        }


        [TestMethod]
        public void Test5()
        {
            var bracket = new Bracket();
            var result = bracket.ValidateInput("[](){}[{()}]");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test6()
        {
            var bracket = new Bracket();
            var result = bracket.ValidateInput("{[(])}");

            Assert.IsFalse(result);
        }
    }
}

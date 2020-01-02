using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StockSpanProblem;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var run = new Program();

            var prices = new List<int> { 100, 80, 60, 70, 60, 75, 85 };

            var actualResult = run.CalculateSpan(prices);

            var expectedResult = new Stack();
            expectedResult.Push(1);
            expectedResult.Push(1);
            expectedResult.Push(1);
            expectedResult.Push(2);
            expectedResult.Push(1);
            expectedResult.Push(4);
            expectedResult.Push(6);

            CollectionAssert.AreEqual(actualResult, expectedResult);

        }

        [TestMethod]
        public void TestMethod2()
        {
            var run = new Program();

            var prices = new List<int> { 85, 100, 70, 60, 60, 50 };

            var actualResult = run.CalculateSpan(prices);

            var expectedResult = new Stack();
            expectedResult.Push(1);
            expectedResult.Push(2);
            expectedResult.Push(1);
            expectedResult.Push(1);
            expectedResult.Push(1);
            expectedResult.Push(1);

            CollectionAssert.AreEqual(actualResult, expectedResult);

        }

        [TestMethod]
        public void TestMethod3()
        {
            var run = new Program();

            var prices = new List<int> { 70, 100, 120, 80, 50, 130 };

            var actualResult = run.CalculateSpan(prices);

            var expectedResult = new Stack();
            expectedResult.Push(1);
            expectedResult.Push(2);
            expectedResult.Push(3);
            expectedResult.Push(2);
            expectedResult.Push(1);
            expectedResult.Push(6);

            CollectionAssert.AreEqual(actualResult, expectedResult);

        }
    }
}

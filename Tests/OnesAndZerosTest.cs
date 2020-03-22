using Codewars;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    public class OnesAndZerosTest
    {
        [Test]
        public static void Test1()
        {
            int[] Test1 = new int[] { 0, 0, 0, 0 };
            Assert.AreEqual(0, OnesAndZeros.binaryArrayToNumber(Test1));
        }
        [Test]
        public static void Test2()
        {
            int[] Test2 = new int[] { 1, 1, 1, 1 };
            Assert.AreEqual(15, OnesAndZeros.binaryArrayToNumber(Test2));
        }
        [Test]
        public static void Test3()
        {
            int[] Test3 = new int[] { 0, 1, 1, 0 };
            Assert.AreEqual(6, OnesAndZeros.binaryArrayToNumber(Test3));
        }
        [Test]
        public static void Test4()
        {
            int[] Test4 = new int[] { 0, 1, 0, 1 };
            Assert.AreEqual(5, OnesAndZeros.binaryArrayToNumber(Test4));
        }
    }
}

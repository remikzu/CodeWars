using Codewars;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    class EqualSidesOfAnArrayTest
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(3, EqualSidesOfAnArray.FindEvenIndex(new int[] { 1, 2, 3, 4, 3, 2, 1 }));
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual(1, EqualSidesOfAnArray.FindEvenIndex(new int[] { 1, 100, 50, -51, 1, 1 }));
        }
        [Test]
        public void Test3()
        {
            Assert.AreEqual(-1, EqualSidesOfAnArray.FindEvenIndex(new int[] { 1, 2, 3, 4, 5, 6 }));
        }
        [Test]
        public void Test4()
        {
            Assert.AreEqual(3, EqualSidesOfAnArray.FindEvenIndex(new int[] { 20, 10, 30, 10, 10, 15, 35 }));
        }
        [Test]
        public void Test5()
        {
            Assert.AreEqual(0, EqualSidesOfAnArray.FindEvenIndex(new int[] { 20, 10, -80, 10, 10, 15, 35 }));
        }

    }
}

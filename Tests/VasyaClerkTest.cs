using Codewars;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    class VasyaClerkTest
    {
        [Test]
        public void Test1()
        {
            int[] peopleInLine = new int[] { 25, 25, 50, 50 };
            Assert.AreEqual("YES", VasyaClerk.Tickets(peopleInLine));
        }

        [Test]
        public void Test2()
        {
            int[] peopleInLine = new int[] { 25, 100 };
            Assert.AreEqual("NO", VasyaClerk.Tickets(peopleInLine));
        }

        [Test]
        public void Test3()
        {
            int[] peopleInLine = new int[] { 25, 25, 50, 100 };
            Assert.AreEqual("YES", VasyaClerk.Tickets(peopleInLine));
        }

        [Test]
        public void Test4()
        {
            int[] peopleInLine = new int[] { 25, 25, 25, 25, 50, 100, 50 };
            Assert.AreEqual("YES", VasyaClerk.Tickets(peopleInLine));
        }
    }
}

using Codewars;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    public class TakeATenMinuteWalkTest
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(true, TakeATenMinuteWalk.IsValidWalk(new string[] { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" }), "should return true");
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual(false, TakeATenMinuteWalk.IsValidWalk(new string[] { "w", "e", "w", "e", "w", "e", "w", "e", "w", "e", "w", "e" }), "should return false");
        }
        [Test]
        public void Test3()
        {
            Assert.AreEqual(false, TakeATenMinuteWalk.IsValidWalk(new string[] { "w" }), "should return false");
        }
        [Test]
        public void Test4()
        {
            Assert.AreEqual(false, TakeATenMinuteWalk.IsValidWalk(new string[] { "n", "n", "n", "s", "n", "s", "n", "s", "n", "s" }), "should return false");
        }

    }
}

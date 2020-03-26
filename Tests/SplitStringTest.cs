using Codewars;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    class SplitStringTest
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(new string[] { "ab", "c_" }, SplitStrings.Solution("abc"));
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual(new string[] { "ab", "cd", "ef" }, SplitStrings.Solution("abcdef"));
        }
    }
}

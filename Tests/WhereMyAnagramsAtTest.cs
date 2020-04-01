using Codewars;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    class WhereMyAnagramsAtTest
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(new List<string> { "carer", "arcre", "carre" }, WhereMyAnagramsAt.Anagrams("racer", new List<string> { "carer", "arcre", "carre", "racrs", "racers", "arceer", "raccer", "carrer", "cerarr" }));
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual(new List<string> { "a" }, WhereMyAnagramsAt.Anagrams("a", new List<string> { "a", "b", "c", "d" }));
        }
    }
}

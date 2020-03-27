using Codewars;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    class ConvertStringToCamelCaseTest
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("theStealthWarrior", ConvertStringToCamelCase.ToCamelCase("the_stealth_warrior"), "Kata.ToCamelCase('the_stealth_warrior') did not return correct value");
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual("TheStealthWarrior", ConvertStringToCamelCase.ToCamelCase("The-Stealth-Warrior"), "Kata.ToCamelCase('The-Stealth-Warrior') did not return correct value");
        }
        [Test]
        public void Test3()
        {
            Assert.AreEqual("ABC", ConvertStringToCamelCase.ToCamelCase("A-B-C"), "Kata.ToCamelCase('ABC') did not return correct value");
        }
    }
}

using Codewars;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestFixture]
    public class WhoLikesItTest
    {
        [Test]
        public static void Test1()
        {
            Assert.AreEqual("no one likes this", WhoLikesIt.Likes(new string[0]));
        }
        [Test]
        public static void Test2()
        {
            Assert.AreEqual("Peter likes this", WhoLikesIt.Likes(new string[] { "Peter" }));
        }
        [Test]
        public static void Test3()
        {
            Assert.AreEqual("Jacob and Alex like this", WhoLikesIt.Likes(new string[] { "Jacob", "Alex" }));
        }
        [Test]
        public static void Test4()
        {
            Assert.AreEqual("Max, John and Mark like this", WhoLikesIt.Likes(new string[] { "Max", "John", "Mark" }));
        }
        [Test]
        public static void Test5()
        {
            Assert.AreEqual("Alex, Jacob and 2 others like this", WhoLikesIt.Likes(new string[] { "Alex", "Jacob", "Mark", "Max" }));
        }
        [Test]
        public static void Test6()
        {
            Assert.AreEqual("Alex, Jacob and 3 others like this", WhoLikesIt.Likes(new string[] { "Alex", "Jacob", "Mark", "Max", "Remik" }));
        }
        [Test]
        public static void Test7()
        {
            Assert.AreEqual("Alex, Jacob and 4 others like this", WhoLikesIt.Likes(new string[] { "Alex", "Jacob", "Mark", "Max", "Remik", "Kasia" }));
        }
    }
}

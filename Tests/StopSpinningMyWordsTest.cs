using Codewars;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    public class StopSpinningMyWordsTest
    {
        [Test]
        public static void ShouldReverseAWord()
        {
            Assert.AreEqual("drow", StopSpinningMyWords.Reverse("word"));
            Assert.AreEqual("emocleW", StopSpinningMyWords.Reverse("Welcome"));
        }
        [Test]
        public static void Test1()
        {
            Assert.AreEqual("emocleW", StopSpinningMyWords.SpinWords("Welcome"));
        }

        [Test]
        public static void Test2()
        {
            Assert.AreEqual("Hey wollef sroirraw", StopSpinningMyWords.SpinWords("Hey fellow warriors"));
        }

        [Test]
        public static void Test3()
        {
            Assert.AreEqual("This is a test", StopSpinningMyWords.SpinWords("This is a test"));
        }

        [Test]
        public static void Test4()
        {
            Assert.AreEqual("This is rehtona test", StopSpinningMyWords.SpinWords("This is another test"));
        }

        [Test]
        public static void Test5()
        {
            Assert.AreEqual("You are tsomla to the last test", StopSpinningMyWords.SpinWords("You are almost to the last test"));
        }

        [Test]
        public static void Test6()
        {
            Assert.AreEqual("Just gniddik ereht is llits one more", StopSpinningMyWords.SpinWords("Just kidding there is still one more"));
        }
    }
}

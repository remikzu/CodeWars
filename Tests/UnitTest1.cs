using NUnit.Framework;
using Codewars;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(true, WillYouMakeIt.ZeroFuel(50, 25, 2));
            Assert.AreEqual(false, WillYouMakeIt.ZeroFuel(100, 50, 1));
        }
    }
}
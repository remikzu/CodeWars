﻿using Codewars;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    class ShortestWordTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(3, ShortestWord.FindShort("bitcoin take over the world maybe who knows perhaps"));
            Assert.AreEqual(3, ShortestWord.FindShort("turns out random test cases are easier than writing out basic ones"));
        }
    }
}

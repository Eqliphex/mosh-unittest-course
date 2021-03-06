﻿using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        // If your arrange code is 3-4 lines who are the same, then we can use
        private Math _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }


        [Test]
        [Ignore("Because i wanted to!")]
        public void Add_WhenCalled_ReturnSumOfArguments()
        {
        
            var result = _math.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
        {
        
            var result = _math.Max(a, b);

            Assert.That(result, Is.EqualTo(expectedResult));

        }
    }
}

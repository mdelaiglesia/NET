using System;
using NUnit.Framework;

namespace NET
{
    [TestFixture]
    public class UnitTest1
    {
        /**
         * Rigourous Test :-)
         */
        [Test]
        public void testApp()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public void testAdd()
        {
            Assert.AreEqual(4, 2 + 2);
        }

        [Test]
        public void testSubtract()
        {
            Assert.AreEqual(0, 2 - 2);
        }
    }
}

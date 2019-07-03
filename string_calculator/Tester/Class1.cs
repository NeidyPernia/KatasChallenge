using System;
using NUnit.Framework;

namespace Tester
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Add_numbers_1_and_2()
        {
            int num1 = Calculator.Add(1, 2);
            Assert.AreEqual(3, num1);
        }
    }
}

using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Add_1_and_2()
        {
            double num1 = Calculator.Add(1, 2);
            Assert.AreEqual(3, num1);
        }

        [Test]
        public void Add_1dot1_2dot1()
        {
            double num1 = Calculator.Add(1.1, 2.1);
            Assert.AreEqual(3.2,num1);
        }

        [Test]
        public void Negatives_not_allowed()
        {
            string num1 = Calculator.Negative(-1, 3);
            Assert.AreEqual("Negatives not allowed: -1", num1);
        }

        [Test]
        public void Show_error_when_space_appear()
        {
            
        }

    }
}
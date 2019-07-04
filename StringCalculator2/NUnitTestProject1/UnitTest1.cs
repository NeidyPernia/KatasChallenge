using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Add_two_number()
        {
            double number = Calculator.Add(1, 3, 0);
            Assert.AreEqual(4, number);
        }

        [Test]
        public void Add_three_numbers()
        {
            double number = Calculator.Add(1, 2, 3);
            Assert.AreEqual(6, number);
        }

        [Test]
        public void Add_number_with_dots()
        {
            double number = Calculator.Add(1.5, 2.6, 3.7);
            Assert.AreEqual(7.8, number);
        }

        [Test]
        public void Error_message_because_negative()
        {
            string number = Calculator.Message(-1, 2, 3);
            Assert.Warn("Negatives not allowed: -1", number);
        }

        [Test]
        public void Error_messsage_besause_an_space()
        {
            string number = Calculator.Message(1,2 ,3);
            Assert.Warn("", );
        }


    }
}
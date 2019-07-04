using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void When_1_return_I()
        {
            string num1 = Translator.Convert(1);
            Assert.AreEqual("I", num1);
        }

        [Test]
        public void When_5_return_V()
        {
            string num1 = Translator.Convert(5);
            Assert.AreEqual("V", num1);
        }

        [Test]
        public void When_10_return_X()
        {
            string num1 = Translator.Convert(10);
            Assert.AreEqual("X", num1);
        }

        [Test]
        public void When_9_return_IX()
        {
            string num1 = Translator.Convert(9);
            Assert.AreEqual("IX", num1);
        }

        [Test]
        public void When_30_return_XXX()
        {
            string num1 = Translator.Convert(30);
            Assert.AreEqual("XXX", num1);
        }

        [Test]
        public void When_50_return_L()
        {
            string num1 = Translator.Convert(50);
            Assert.AreEqual("L", num1);
        }

        [Test]
        public void When_100_return_C()
        {
            string num1 = Translator.Convert(100);
            Assert.AreEqual("C", num1);
        }

        [Test]
        public void When_500_return_D()
        {
            string num1 = Translator.Convert(500);
            Assert.AreEqual("D", num1);
        }




    }
}
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void If_1_return_I()
        {
            string val = Translator.Convert(1);
            Assert.AreEqual("I", val);
        }

        [Test]
        public void If_3_return_III()
        {
            string val = Translator.Convert(3);
            Assert.AreEqual("III",val);
        }
        [Test]
        public void If_10_return_X()
        {
            string val = Translator.Convert(10);
            Assert.AreEqual("X", val);
        }
    }
}
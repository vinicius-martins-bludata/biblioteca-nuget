using NUnit.Framework;

namespace Library.Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Append_TestOne()
        {
            Assert.That(Util.Append("Teste") == "Hello Teste");
        }

        [Test]
        public void Append_TestTwo()
        {
            Assert.That(Util.Append("Teste") == "Hello Teste");
        }
    }
}
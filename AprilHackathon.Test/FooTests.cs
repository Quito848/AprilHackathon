using NUnit.Framework;

namespace AprilHackathon.Test
{
    [TestFixture]
    class FooTests
    {
        [Test]
        public void ReturnHelloWorldTest()
        {
            Assert.That(new Foo().ReturnHelloWorld(), Is.EqualTo("Hello World"));
        }

        [Test]
        public void ReturnTwoTest()
        {
            Assert.That(new Foo().ReturnTwo(), Is.EqualTo(2));
        }
    }
}

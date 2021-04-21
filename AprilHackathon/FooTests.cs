using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AprilHackathon
{
    [TestFixture]
    class FooTests
    {
        [Test]
        public void ReturnHelloWorldTest()
        {
            Assert.That(new Foo().ReturnHelloWorld(), Is.EqualTo("Hello World"));
        }
    }
}

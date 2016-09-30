using NUnit.Framework;
using Shouldly;

namespace DesignPatterns
{
    [TestFixture]
    public class DuckTest
    {
        [Test]
        public void test1()
        {
            true.ShouldBe(true);
        }
    }
}

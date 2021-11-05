using NUnit.Framework;

namespace TestProject
{
    public class Tests
    {
        [Test]
        [TestCase(1)]
        public void Test1(int expected)
        {
            Assert.AreEqual(expected, 1);
            Assert.Pass();
        }
    }
}
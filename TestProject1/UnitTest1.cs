using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using zadanie2;

namespace TestProject2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int res = Logic.Multiply(5, 3);
            Assert.AreEqual(15, res);
        }

        [Test]
        public void Test2()
        {
            int res = Logic.Multiply(0, 7);
            Assert.AreEqual(0, res);
        }

        [Test]
        public void Test3()
        {
            int res = Logic.Multiply(1, 9);
            Assert.AreEqual(9, res);
        }
    }
}

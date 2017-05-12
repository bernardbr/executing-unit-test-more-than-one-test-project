namespace Test.Unit
{
    using model;
    using NUnit.Framework;

    [TestFixture]
    public class TestCalc
    {
        [Test]
        public void TestMethod()
        {
            Assert.AreEqual(5, Calc.Sum(2, 1, 2));
        }

        [Test]
        public void TestFailMethod()
        {
            Assert.AreEqual(6, Calc.Sum(2, 1, 2));
        }
    }
}
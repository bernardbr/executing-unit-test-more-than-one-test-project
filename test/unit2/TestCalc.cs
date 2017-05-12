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
            Assert.AreEqual(6, Calc.Sum(2, 1, 2) + 1);
        }

        [Test]
        public void TestFailMethod()
        {
            Assert.AreEqual(7, Calc.Sum(2, 1, 2));
        }
    }
}
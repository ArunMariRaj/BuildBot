using NUnit.Framework;

namespace BuildBotTrial.Tests
{
    [TestFixture]
    class CalculatorTests
    {
        Calculator calculator = new Calculator();
        [Test]
        public void AddingTwoNumbers()
        {
            calculator.FirstNumber = 20;
            calculator.SecondNumber = 30;
            int Actual = calculator.Add();
            int Expected = 50;
            Assert.AreEqual(Expected, Actual);
        }
    }
}

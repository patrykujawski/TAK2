using ConsoleApp1;
using NUnit.Framework;

namespace RPNUnitTests
{
    public class RpnTests
    {
        [TestCase("2 3 +", 5)]
        [TestCase("2 3 -", -1)]
        [TestCase("2 2 2 2 + - *", -4)]
        [TestCase("2 2 2 2 2 2 2 + - * + - *", 8)]
        [TestCase("12 2 3 4 * 10 5 + + * +", 66)]
        [TestCase("-12 2 3 4 * 10 5 + + * +", 42)]
        [TestCase("-12 2 0 4 * 10 5 + + * +", 18)]
        public void Calculate_Always_Success(string expression, int expectedValue)
        {
            var rpn = new Rpn();

            var calculate = rpn.Calculate(expression);

            Assert.AreEqual(expectedValue, calculate);
        }
    }
}

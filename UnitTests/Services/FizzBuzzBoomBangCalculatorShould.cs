using FizzBuzz.Services;
using NUnit.Framework;

namespace UnitTests.Services
{
    public class FizzBuzzBoomBangCalculatorShould
    {
        private ICalculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new FizzBuzzBoomBangCalculator(new FizzBuzzBoomCalculator(new FizzBuzzCalculator()));
        }

        [TestCase(73)]
        [TestCase(47)]
        [TestCase(7)]
        public void return_bang_when_number_contains_7_not_1_or_divisible_by_3_or_5(int number)
        {
            var result = _calculator.GetValue(number);

            Assert.That(result.Equals("Bang"));
        }
    }
}

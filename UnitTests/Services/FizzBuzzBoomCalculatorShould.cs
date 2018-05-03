using FizzBuzz.Services;
using NUnit.Framework;

namespace UnitTests.Services
{
    [TestFixture]
    public class FizzBuzzBoomCalculatorShould
    {
        private FizzBuzzBoomCalculator _baseCalculator;

        [SetUp]
        public void Setup()
        {
            _baseCalculator = new FizzBuzzBoomCalculator(new FizzBuzzCalculator());
        }


        [TestCase(1)]
        [TestCase(31)]
        [TestCase(91)]
        public void return_boom_when_number_contains_one_and_is_not_divisble_by_three_or_five(int number)
        {
            var result = _baseCalculator.GetValue(number);

            Assert.That(result.Equals("Boom"));
        }

    }
}

using FizzBuzz.Services;
using NUnit.Framework;

namespace UnitTests.Services
{
    [TestFixture]
    public class FizzBuzzServiceShould
    {
        private FizzBuzzCalculator _fizzBuzzCalculator;

        [SetUp]
        public void Setup()
        {
            _fizzBuzzCalculator = new FizzBuzzCalculator();
        }

        [TestCase(3)]
        [TestCase(39)]
        [TestCase(93)]
        public void return_fizz_when_input_is_divisible_by_three(int input)
        {
            // Act
            var textReturned = _fizzBuzzCalculator.GetValue(input);

            // Assert
            Assert.That(textReturned.Equals("Fizz"));
        }

        [TestCase(5)]
        [TestCase(65)]
        [TestCase(80)]
        public void return_buzz_when_input_is_divisible_by_five(int input)
        {
            // Act
            var textReturned = _fizzBuzzCalculator.GetValue(input);

            // Assert
            Assert.That(textReturned.Equals("Buzz"));
        }

        [TestCase(15)]
        [TestCase(45)]
        [TestCase(75)]
        public void return_fizzbuzz_when_input_is_divisible_by_three_and_five(int input)
        {
            // Act
            var textReturned = _fizzBuzzCalculator.GetValue(input);

            // Assert
            Assert.That(textReturned.Equals("FizzBuzz"));
        }

        [TestCase(33)]
        [TestCase(63)]
        [TestCase(93)]
        public void return_fizz_when_input_contains_three(int input)
        {
            // Act
            var textReturned = _fizzBuzzCalculator.GetValue(input);

            // Assert
            Assert.That(textReturned.Equals("Fizz"));
        }

        [TestCase(55)]
        [TestCase(85)]
        [TestCase(25)]
        public void return_fizz_when_input_contains_five(int input)
        {
            // Act
            var textReturned = _fizzBuzzCalculator.GetValue(input);

            // Assert
            Assert.That(textReturned.Equals("Buzz"));
        }
    }
}

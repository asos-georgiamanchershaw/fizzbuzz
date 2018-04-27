using FizzBuzz.Services;
using NUnit.Framework;

namespace UnitTests.Services
{
    [TestFixture]
    public class CalculatorShould
    {
        [Test]
        [TestCase(9)]
        [TestCase(21)]
        [TestCase(99)]
        public void return_true_when_input_is_divisible_by_three(int input)
        {
            // Act
            var actual = Calculator.IsDivisibleBy(input, 3);

            // Assert
            Assert.That(actual.Equals(true));
        }

        [Test]
        [TestCase(25)]
        [TestCase(100)]
        [TestCase(30)]
        public void return_true_when_input_is_divisible_by_five(int input)
        {
            // Act
            var actual = Calculator.IsDivisibleBy(input, 5);

            // Assert
            Assert.That(actual.Equals(true));
        }

        [Test]
        [TestCase(15)]
        [TestCase(75)]
        [TestCase(90)]
        public void return_true_when_input_is_divisible_by_three_and_five(int input)
        {
            // Act
            bool isDivisible = Calculator.IsDivisibleBy(input, 3) && Calculator.IsDivisibleBy(input, 5);

            // Assert
            Assert.That(isDivisible.Equals(true));
        }

        [Test]
        [TestCase(37)]
        [TestCase(63)]
        [TestCase(13)]
        public void return_true_when_input_contains_three(int input)
        {
            // Act
            bool containsThree = Calculator.ContainsNumber(input, 3);

            // Assert
            Assert.That(containsThree.Equals(true));
        }

        [Test]
        [TestCase(45)]
        [TestCase(57)]
        [TestCase(95)]
        public void return_true_when_input_contains_five(int input)
        {
            // Act
            bool containsThree = Calculator.ContainsNumber(input, 5);

            // Assert
            Assert.That(containsThree.Equals(true));
        }

    }
}


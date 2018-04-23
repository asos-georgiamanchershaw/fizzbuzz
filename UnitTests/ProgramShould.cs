using FizzBuzz;
using NUnit.Framework;

namespace UnitTests
{
    //[TestFixture]
    public class ProgramShould
    {
        [Test]
        [TestCase(9)]
        public void return_fizz_when_input_is_divisible_by_three(int input)
        {
            // Arrange


            // Act
            var sut = new Program();

            // Assert

        }

    }
}

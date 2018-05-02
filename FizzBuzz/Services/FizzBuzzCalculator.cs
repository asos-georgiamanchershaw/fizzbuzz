namespace FizzBuzz.Services
{
    public class FizzBuzzCalculator
    {
        public string GetValue(int number)
        {
            bool isDivisibleBy3And5 = Calculator.IsDivisibleBy(number, 3) && Calculator.IsDivisibleBy(number, 5);
            if (isDivisibleBy3And5)
            {
                return "FizzBuzz";
            }

            bool isDivisibleBy3 = Calculator.IsDivisibleBy(number, 3);
            if (isDivisibleBy3)
            {
                return "Fizz";
            }

            bool isDivisibleBy5 = Calculator.IsDivisibleBy(number, 5);
            if (isDivisibleBy5)
            {
                return "Buzz";
            }

            return number.ToString();
        }
    }
}

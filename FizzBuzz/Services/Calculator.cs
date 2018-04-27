namespace FizzBuzz.Services
{
    public class Calculator
    {
        public static bool IsDivisibleBy(int input, int divisibleBy)
        {
            if (input % divisibleBy == 0)
            {
                return true;
            }

            return false;
        }

        public static bool ContainsNumber(int input, int number)
        {
            // what happens for 35... contains 3, 5 and divisible by 5
            
            if (input.ToString().Contains(number.ToString()))
            {
                return true;
            }

            return false;

        }
    }
}

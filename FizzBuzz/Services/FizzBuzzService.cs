namespace FizzBuzz.Services
{
    public class FizzBuzzService
    {
        public string ProcessInput(int input)
        {
            string convertedInput = string.Empty;


            bool isDivisibleByThree = Calculator.IsDivisibleBy(input, 3);
            bool isDivisibleByFive = Calculator.IsDivisibleBy(input, 5);
            bool isDivisibleByThreeAndFive = Calculator.IsDivisibleBy(input, 3) && Calculator.IsDivisibleBy(input, 5);
            bool containsThree = Calculator.ContainsNumber(input, 3);
            bool containsFive = Calculator.ContainsNumber(input, 5);

            if (isDivisibleByThreeAndFive)
            {
                convertedInput = "FizzBuzz";
            }
            else if (isDivisibleByThree || containsThree)
            {
                convertedInput = "Fizz";
            }
            else if (isDivisibleByFive || containsFive)
            {
                convertedInput = "Buzz";
            }
            else convertedInput = input.ToString();


            return convertedInput;
        }
    }
}

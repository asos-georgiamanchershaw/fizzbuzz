namespace FizzBuzz.Services
{
    public class FizzBuzzBoomBangCalculator : ICalculator
    {
        private ICalculator _calculator;

        public FizzBuzzBoomBangCalculator(ICalculator calculator)
        {
            _calculator = calculator;
        }

        public string GetValue(int number)
        {
            var result = _calculator.GetValue(number);

            if (result.Contains("7"))
            {
                return "Bang";
            }

            return result;
        }
    }
}

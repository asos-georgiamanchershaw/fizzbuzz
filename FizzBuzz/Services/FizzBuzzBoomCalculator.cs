namespace FizzBuzz.Services
{
    public class FizzBuzzBoomCalculator : ICalculator
    {
        private ICalculator _baseCalculator;

        public FizzBuzzBoomCalculator(ICalculator baseCalculator)
        {
            _baseCalculator = baseCalculator;
        }

        public string GetValue(int number)
        {
            string result = _baseCalculator.GetValue(number);

            if (result.Contains("1"))
            {
                return "Boom";
            }

            return result;
        }
    }
}

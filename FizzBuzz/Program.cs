using System;
using FizzBuzz.Services;

namespace FizzBuzz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var fizzBuzzService = new FizzBuzzCalculator();

            for (int i = 1; i <= 1000; i++)
            {
                var replacementText = fizzBuzzService.GetValue(i);
                Console.WriteLine(replacementText);
            }

            Console.ReadLine();
        }
    }
}

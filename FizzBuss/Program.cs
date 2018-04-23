using System;
using System.Diagnostics;
using FizzBuss.Validators;

namespace FizzBuzz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                bool isDivisibleByThree = InputValidator.IsDivisibleBy(i, 3);
                bool isDivisibleByFive = InputValidator.IsDivisibleBy(i, 5);
                bool isDivisibleByThreeAndFive = InputValidator.IsDivisibleBy(i, 3) && InputValidator.IsDivisibleBy(i, 5);
                bool containsThree = InputValidator.ContainsNumber(i, 3);
                bool containsFive = InputValidator.ContainsNumber(i, 5);

                if (isDivisibleByThreeAndFive)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (isDivisibleByThree || containsThree)
                {
                    Console.WriteLine("Fizz");
                }
                else if (isDivisibleByFive || containsFive)
                {
                    Console.WriteLine("Buzz");
                }
                else Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}

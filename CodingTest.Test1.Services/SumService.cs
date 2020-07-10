using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingTest.Test1.Services
{
    public class SumService
    {
        public string SumNumbers(int firstNumber, int secondNumber)
        {
            return $"The sum of {firstNumber} and {secondNumber} is {firstNumber + secondNumber}";
        }
        
        public string SumNumbers(List<int> numbers)
        {
            if (!numbers.Any())
            {
                return $"Your sum is 0";
            }
            if (numbers.Count == 1)
            {
                return $"Your number is {numbers.First()}";
            }
            if (numbers.Count == 2)
            {
                var firstNumber = numbers[0];
                var secondNumber = numbers[1];
                return SumNumbers(firstNumber, secondNumber);
            }

            var allButOne = numbers.GetRange(0, numbers.Count() - 1);
            var ns = string.Join(", ", allButOne);

            return $"The sum of {ns} and {numbers.Last()} is {numbers.Sum()}";
        }
    }
}

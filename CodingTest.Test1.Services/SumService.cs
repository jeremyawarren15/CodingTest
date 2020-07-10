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

    }
}

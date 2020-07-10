using System;

namespace Test1.Services
{
    public class PrintService
    {
        public string PrintSumNumbers(int firstNumber, int secondNumber)
        {
            return $"The sum of {firstNumber} and {secondNumber} is {firstNumber + secondNumber}";
        }
    }
}

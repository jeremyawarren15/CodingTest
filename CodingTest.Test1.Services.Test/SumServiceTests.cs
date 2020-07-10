using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.Test1.Services.Test
{
    [TestFixture]
    public class SumServiceTests
    {
        private readonly SumService _sumService;
        public SumServiceTests()
        {
            _sumService = new SumService();
        }

        [TestCase(3, 6)]
        [TestCase(0, 0)]
        [TestCase(37529, 423345)]
        [TestCase(1, -23)]
        [TestCase(-1, -23)]
        public void SumNumbers_GivenTwoNumbers_ReturnsLikeOldVersion(int firstNumber, int secondNumber)
        {
            var numbers = new List<int>() { firstNumber, secondNumber };

            var result = _sumService.SumNumbers(numbers);
            var expected = $"The sum of {firstNumber} and {secondNumber} is {firstNumber + secondNumber}";

            Assert.AreEqual(expected, result);
        }

        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(-0)]
        [TestCase(1)]
        [TestCase(10)]
        [TestCase(5898902)]
        public void SumNumbers_GivenOneNumber_ReturnsOnlyThatNumber(int number)
        {
            var numbers = new List<int>() { number };

            var result = _sumService.SumNumbers(numbers);
            var expected = $"Your number is {number}";

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void SumNumbers_GivenLotsOfNumbers_ReturnsAllNumbersWithSum()
        {
            var numbers = new List<int>()
            {
                46191,
                15518,
                41581,
                37813,
                1662,
                6744,
                26345,
                29128,
                28993,
                44660,
                9531,
                23514,
                19591,
                13578,
                35709,
                37841,
                20163,
                8701
            };

            var result = _sumService.SumNumbers(numbers);
            var expected = $"The sum of 46191, 15518, 41581, 37813, 1662, 6744, 26345, 29128, 28993, 44660, 9531, 23514, 19591, 13578, 35709, 37841, 20163 and 8701 is 447263";

            Assert.AreEqual(expected, result);
        }
    }
}

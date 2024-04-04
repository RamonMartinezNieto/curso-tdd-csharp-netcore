using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTest
    {
        [TestCase(0, "1")]
        [TestCase(1, "2")]
        public void PositionShouldHaveNumber(int index, string number)
        {
            var sut = new FizzBuzz();

            var result = sut.Execute();

            result[index].Should().Be(number);
        }

        [TestCase(2)]
        [TestCase(5)]
        public void MultipleOfThreeShouldBeFizz(int index)
        {
            var sut = new FizzBuzz();

            var result = sut.Execute();

            result[index].Should().Be("Fizz");
        }

        [TestCase(4)]
        [TestCase(9)]
        public void MultipleOfFifthShouldBeBuzz(int index)
        {
            var sut = new FizzBuzz();

            var result = sut.Execute();

            result[index].Should().Be("Buzz");
        }


        [TestCase(14)]
        [TestCase(29)]
        public void MultipleOfFifteenShouldBeFizzBuzz(int index)
        {
            var sut = new FizzBuzz();

            var result = sut.Execute();

            result[index].Should().Be("FizzBuzz");
        }



    }
}
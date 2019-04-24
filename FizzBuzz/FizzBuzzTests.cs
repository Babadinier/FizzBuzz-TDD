using FizzBuzzServices;
using Xunit;

namespace FizzBuzz
{
    public class FizzBuzzTests
    {
        private readonly FizzBuzzer fizzBuzz;
        public FizzBuzzTests()
        {
            fizzBuzz = new FizzBuzzer();
        }

        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(4, "4")]
        [InlineData(7, "7")]
        [InlineData(8, "8")]
        public void should_return_number_to_string_when_not_divide_by_3_or_5(int number, string expected)
        {
            var result = fizzBuzz.GetValue(number);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(3, "Fizz")]
        [InlineData(6, "Fizz")]
        [InlineData(9, "Fizz")]
        public void should_return_Fizz_when_number_is_divide_by_3(int number, string expected)
        {
            var result = fizzBuzz.GetValue(number);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, "Buzz")]
        [InlineData(10, "Buzz")]
        public void should_return_Buzz_when_number_is_divide_by_5(int number, string expected)
        {
            var result = fizzBuzz.GetValue(number);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(15, "FizzBuzz")]
        public void should_return_FizzBuzz_when_number_is_divide_by_3_and_5(int number, string expected)
        {
            var result = fizzBuzz.GetValue(number);
            Assert.Equal(expected, result);
        }
    }
}

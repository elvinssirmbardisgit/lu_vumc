using LU_VUMC_Project;
using System;
using Xunit;

namespace UnitTests.Tests
{
    /// <summary>
    /// Ja skaitlis dalās ar 3 tad atgriez "Fizz" 
    /// ja skaitlis dalās ar 5 tad atgriez "Buzz"
    /// ja skaitlis dalās ar 3 un 5 tad atgriez "FizzBuzz"
    /// ja skaitlis nedalās ar 3 vai 5 tad atgriez pašu skaitlis
    /// </summary>
    public class UnitTest1
    {
        // Metode_When_Then

        [Fact]
        public void GetFizzNumber_WhenNumberDoesNotDivideBy30r5_ThenReturnsNumber()
        {

            //arrange
            var fizzClass = new FizzBuzz();
            //act
            string fizzResponse = fizzClass.GetFizzNumber(6);
            //assert
            Assert.Equal("Fizz", fizzResponse);

            }

            [Theory]
            [InlineData(3)]
            [InlineData(6)]
            [InlineData(9)]
            [InlineData(12)]
            public void GetFizzNumber_WhenNumberDividesBy3_ThenReturnsFizz(int testableNumber)
            {
                // arrange
                var fizzClass = new FizzBuzz();

                // act
                string fizzResponse = fizzClass.GetFizzNumber(testableNumber);

                // assert
                Assert.Equal("Fizz", fizzResponse);
            }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        public void GetFizzNumber_WhenNumberDividesBy5_ThenReturnsFizz(int testableNumber)
        {
            // arrange
            var fizzClass = new FizzBuzz();

            // act
            string fizzResponse = fizzClass.GetFizzNumber(testableNumber);

            // assert
            Assert.Equal("Buzz", fizzResponse);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(60)]
        public void GetFizzNumber_WhenNumberDivides3and5_ThenReturnsFizz(int testableNumber)
        {
            // arrange
            var fizzClass = new FizzBuzz();

            // act
            string fizzResponse = fizzClass.GetFizzNumber(testableNumber);

            // assert
            Assert.Equal("FizzBuzz", fizzResponse);
        }







    }
}

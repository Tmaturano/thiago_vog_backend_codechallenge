using System;
using Xunit;

namespace VogCodeChallenge.Console.Test
{
    public class ConsoleUnitTest
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        public void TESTModule_WhenIntegerIs1_2_3_4_ShouldReturnMultipleValueBy2(int value)
        {
            // Arrange
            var expectedValue = value * 2;

            // Act
            var returnedValue = QuestionClass.TESTModule(value);

            // Assert
            Assert.Equal(expectedValue, returnedValue);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(6)]
        public void TESTModule_WhenIntegerIsBiggerThan4_ShouldReturnMultipleValueBy3(int value)
        {
            // Arrange
            var expectedValue = value * 3;

            // Act
            var returnedValue = QuestionClass.TESTModule(value);

            // Assert
            Assert.Equal(expectedValue, returnedValue);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void TESTModule_WhenFloatIs1_2_ShouldReturn3(float value)
        {
            // Arrange
            var expectedValue = 3;

            // Act
            var returnedValue = QuestionClass.TESTModule(value);

            // Assert
            Assert.Equal(expectedValue, returnedValue);
        }

        [Theory]
        [InlineData("test")]        
        public void TESTModule_WhenString_ShouldReturnInUpperCase(string value)
        {
            // Arrange
            var expectedValue = value.ToUpper();

            // Act
            var returnedValue = QuestionClass.TESTModule(value);

            // Assert
            Assert.Equal(expectedValue, returnedValue);
        }

        [Theory]        
        [InlineData(5.0f)]
        [InlineData(1.0d)]        
        public void TESTModule_WhenAnythingElse_ShouldReturnTheValueItself(dynamic value)
        {
            // Arrange
            var expectedValue = value;

            // Act
            var returnedValue = QuestionClass.TESTModule(value);

            // Assert
            Assert.Equal(expectedValue, returnedValue);
        }
    }
}

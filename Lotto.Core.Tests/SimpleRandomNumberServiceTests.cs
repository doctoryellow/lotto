using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Lotto.Core.Tests
{
    public class SimpleRandomNumberServiceTests
    {
        [Fact]
        public void GetRandomNumber_ShouldReturnSingleNumber_WithSetSizeOfOne()
        {
            // Arrange
            var service = new SimpleRandomNumberService();

            // Act
            var result = service.GetRandomInteger(42, 42);

            // Assert
            Assert.Equal(42, result);
        }
    }
}

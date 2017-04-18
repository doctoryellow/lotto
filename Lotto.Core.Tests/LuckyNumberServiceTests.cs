using Moq;
using System;
using System.Linq;
using Xunit;

namespace Lotto.Core.Tests
{
    public class LuckyNumberServiceTests
    {
        [Fact]
        public void DrawNumbers_ShouldReturnAllNumbers1to49()
        {
            // Arrange
            var randomNumberGeneratorMock = new Mock<IRandomNumberService>();

            randomNumberGeneratorMock
                .Setup(m => m.GetRandomInteger(It.IsAny<int>(), It.IsAny<int>()))
                .Returns(0);

            var service = new LuckyNumberService(randomNumberGeneratorMock.Object);

            // Act
            var result = service
                .DrawNumbers()
                .ToList();

            // Assert
            Assert.Equal(49, result.Count);

            var sortedResult = result.OrderBy(x => x);
            Assert.Equal(Enumerable.Range(1, 49), sortedResult);
        }
    }
}

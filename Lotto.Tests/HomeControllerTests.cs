using Lotto.Controllers;
using System;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using Lotto.ViewModels;
using Lotto.Core;
using Moq;
using System.Linq;

namespace Lotto.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index_ShouldReturnView_WithViewModelAndSixNumbers()
        {
            // Arrange
            var luckyNumberGeneratorMock = new Mock<ILuckyNumberService>();

            luckyNumberGeneratorMock
                .Setup(m => m.DrawNumbers())
                .Returns(Enumerable.Range(1, 49));
            
            var controller = new HomeController(luckyNumberGeneratorMock.Object);


            // Act
            var result = controller.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<HomeViewModel>(viewResult.Model);

            Assert.Equal(6, model.Balls.Count);
            Assert.Equal(new[] { 1, 2, 3, 4, 5, 6 }, model.Balls.Select(b => b.Number));
        }


        [Fact]
        public void Index_ShouldReturnView_WithNumbersInAscendingOrder()
        {
            // Arrange
            var luckyNumberGeneratorMock = new Mock<ILuckyNumberService>();

            luckyNumberGeneratorMock
                .Setup(m => m.DrawNumbers())
                .Returns(Enumerable.Range(1, 49).Reverse()); // numbers in reverse order

            var controller = new HomeController(luckyNumberGeneratorMock.Object);


            // Act
            var result = controller.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<HomeViewModel>(viewResult.Model);

            Assert.Equal(6, model.Balls.Count);
            Assert.Equal(new[] { 44, 45, 46, 47, 48, 49 }, model.Balls.Select(b => b.Number));
        }
    }
}

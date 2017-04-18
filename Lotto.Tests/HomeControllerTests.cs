using Lotto.Controllers;
using System;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using Lotto.ViewModels;

namespace Lotto.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index_ShouldReturnViewWithViewModel()
        {
            // Arrange
            var controller = new HomeController();


            // Act
            var result = controller.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<HomeViewModel>(viewResult.Model);



        }
    }
}

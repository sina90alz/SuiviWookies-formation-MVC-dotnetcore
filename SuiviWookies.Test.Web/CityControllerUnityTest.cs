using Microsoft.AspNetCore.Mvc;
using SuiviWookies.Controllers;
using SuiviWookies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SuiviWookies.Test.Web
{
    public class CityControllerUnityTest
    {
        [Fact]
        public void ShouldRun()
        {
            CityController controller = new(new Core.Services.CityService(new Core.Services.BirthService()));
            Assert.NotNull(controller);
        }

        [Fact]
        public void ShouldGetTwoCities()
        {
            // Arrange

            CityController controller = new(new Core.Services.CityService(new Core.Services.BirthService()));

            // Act

            var result = controller.Index();

            // Assert

            var viewResult = Assert.IsType<ViewResult>(result);

            var model = Assert.IsAssignableFrom<CityViewModel>(viewResult.ViewData.Model);

            Assert.Equal(2, model.Villages.Count);
        }
    }
}

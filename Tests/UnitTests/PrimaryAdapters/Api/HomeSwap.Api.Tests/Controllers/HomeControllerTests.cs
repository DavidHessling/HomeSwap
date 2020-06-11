using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using HomeSwap.Api.Controllers;
using HomeSwap.Api.Models;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace HomeSwap.Api.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTests
    {
        private HomeController _homeController;

        [SetUp]
        public void Setup()
        {
            _homeController = new HomeController();
        }

        [Test]
        public void Constructor_HomeController_Not_Null()
        {
            Assert.NotNull(_homeController);
        }

        [Test]
        public async Task GetHomes_Returns_A_List()
        {
            // Act
            var result = await _homeController.GetHomesAsync() as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.IsInstanceOf<IEnumerable>(result.Value);
        }

        [Test]
        public async Task GetHomes_Returns_A_List_Of_HomeDtos()
        {
            // Act
            var result = await _homeController.GetHomesAsync() as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.IsInstanceOf<IEnumerable<HomeDto>>(result.Value);
        }

        [Test]
        public async Task GetHomes_Returns_Ok_Response()
        {
            // Act
            var homes = await _homeController.GetHomesAsync();

            // Assert
            Assert.IsInstanceOf<OkObjectResult>(homes);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using HomeSwap.Api.Controllers;
using HomeSwap.Api.Dtos;
using HomeSwap.UseCases.Abstractions.Home.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;

namespace HomeSwap.Api.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTests
    {
        private HomeController _homeController;
        private readonly Mock<IMediator> _mediatorMock = new Mock<IMediator>();
        private readonly Mock<IGetHomesQuery> _queryMock =  new Mock<IGetHomesQuery>();

        [SetUp]
        public void Setup()
        {
            _homeController = new HomeController(_mediatorMock.Object, _queryMock.Object);
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

        //[Test]
        //public async Task GetHomes_Returns_A_List_Of_HomeDtos()
        //{
        //    // Act
        //    _mediatorMock.Setup(x => x.Send(It.IsAny<IRequest<IEnumerable<HomeDto>>>(), It.IsAny<CancellationToken>()))
        //        .Returns(Task.FromResult(new List<IHome>()));
        //    //.ReturnsAsync(new List<HomeDto>());
        //    var result = await _homeController.GetHomesAsync() as OkObjectResult;

        //    // Assert
        //    Assert.NotNull(result);
        //    Assert.IsInstanceOf<IEnumerable<HomeDto>>(result.Value);
        //}

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

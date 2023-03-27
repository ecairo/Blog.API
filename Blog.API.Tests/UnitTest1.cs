using AutoMapper;
using Moq;

namespace Blog.API.Tests
{
    public class UnitTest1
    {
        public IMapper GetMapper()
        {
            throw new NotImplementedException();
            //var mappingProfile = new UserProfile();
            //var configuration = new MapperConfiguration(cfg => cfg.AddProfile(mappingProfile));
            //return new Mapper(configuration);
        }

        [Fact]
        public void Test1()
        {
            //// Mock
            //// Arrange
            //var r = new Game()
            //{
            //    Id = Guid.Empty,
            //    Name = "Game Test",
            //};

            //var mockGameRepo = new Mock<IGameRepository>();
            //mockGameRepo.Setup(repo => repo.CreateUserGameAsync(It.IsAny<Guid>(), It.IsAny<Game>()));

            //var mockUserRepo = new Mock<IUserRepository>();
            //mockUserRepo.Setup(m => m.GetUserAsync(It.IsAny<Guid>())).Returns(Task.FromResult<User?>(new User()));


            //var mockLogger = new Mock<ILogger<GamesController>>();
            //ILogger<GamesController> logger = mockLogger.Object;

            //var controller = new GamesController(mockGameRepo.Object, mockUserRepo.Object, , logger);
            //controller.ModelState.AddModelError("Name", "Name is required");

            //// arrange
            //// Configurar los datos, objetc...

            //// act
            //// Donde invocas lo que vas a probar
            //controller.UserGamesAsync

            //// assert
            //// Verificar el resultado de la invocacio o act
            //Assert.
        }
    }
}
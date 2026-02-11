using Application.Users;
using Bogus;
using Moq;

namespace Application.Tests;

public class UserServiceTests
{
    private readonly Faker _faker = new Faker();

    [Fact]
    public async Task CreateUserIsCalled()
    {
        var userRepositoryMock = new Mock<IUserRepository>();
        var userService = new UserService(userRepositoryMock.Object);

        await userService.CreateUserAsync(_faker.Internet.Email(), _faker.Internet.Password());

        userRepositoryMock.Verify(x => x.CreateUserAsync(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
    }
}
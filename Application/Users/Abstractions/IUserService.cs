namespace Application.Users;

public interface IUserService
{
    public Task CreateUserAsync(string email, string password);
}
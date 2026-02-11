namespace Application.Users;

public interface IUserRepository
{
    Task CreateUserAsync(string email, string hashedPassword);
}
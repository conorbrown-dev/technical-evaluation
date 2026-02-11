namespace Application.Users;

public class UserService(IUserRepository userRepository) : IUserService
{
    public async Task CreateUserAsync(string email, string password)
    {
        var hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

        await userRepository.CreateUserAsync(email, hashedPassword);
    }
}
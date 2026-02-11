using Application.Users;
using Domain.Entities;

namespace Infrastructure.Persistence.Repositories;

public class UserRepository(ApplicationDbContext dbContext) : IUserRepository
{
    public async Task CreateUserAsync(string email, string hashedPassword)
    {
        await dbContext.Users.AddAsync(new User()
        {
            Email = email,
            PasswordHash = hashedPassword
        });
    }
}

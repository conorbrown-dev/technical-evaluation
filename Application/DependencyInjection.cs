using Application.Users;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IUserValidator, UserValidator>();
        services.AddScoped<IUserService, UserService>();

        return services;
    }
}
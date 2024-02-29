using Domain.Interfaces;
using Domain.Services;
using Infrastructure.Repositories;

namespace backend.Configuration;

public static class DIConfiguration
{
    public static void AddDependecyInjection(this IServiceCollection services)
    {
        services.AddTransient<IUserRepository, UserRepository>();
        services.AddTransient<IAddUserService, AddUserService>();
    }
}

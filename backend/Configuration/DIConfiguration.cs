using Domain.Interfaces;
using Domain.Services;
using Infrastructure.Repositories;
using Microsoft.Extensions.Caching.Memory;

namespace backend.Configuration;

public static class DIConfiguration
{
    public static void AddDependecyInjection(this IServiceCollection services)
    {
        services.AddTransient<IUserRepository, UserRepository>();
        services.AddTransient<IAddUserService, AddUserService>();
        services.AddSingleton<IMemoryCache, MemoryCache>();
        services.AddTransient<IUserService, UserService>();
        services.AddTransient<IListUserService, ListUserService>();
    }
}

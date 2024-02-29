using Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace backend.Configuration;

public static class EFConfiguration
{
    public static void AddDbContextConfiguration(this IServiceCollection service, IConfigurationManager configuration)
    {
        service.AddDbContext<ProjectContext>
            (options => options.UseSqlServer(configuration.GetConnectionString("SqlServer")));
    }

    public static void MigrateDatabase(IConfigurationManager configuration)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ProjectContext>();
        var options = optionsBuilder.UseSqlServer(configuration.GetConnectionString("SqlServer")).Options;
        using var context = new ProjectContext(options);
        context.Database.Migrate();
    }
}

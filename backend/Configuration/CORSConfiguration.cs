namespace backend.Configuration;

public static class CORSConfiguration
{
    public static IApplicationBuilder ConfigureCORS(this WebApplication applicationBuilder,
    IConfiguration configuration)
    {
        applicationBuilder.UseCors(
            builder => builder
                .WithOrigins(configuration.GetSection("AllowedOrigins").Get<string[]>()!)
                .AllowAnyHeader()
                .AllowAnyMethod()
                .AllowCredentials());

        return applicationBuilder;
    }
}

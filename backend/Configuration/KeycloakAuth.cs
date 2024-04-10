using Domain.Security;
using Keycloak.AuthServices.Authentication;
using Keycloak.AuthServices.Authorization;
using Keycloak.AuthServices.Sdk.Admin;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace backend.Configuration;

public static class KeycloakAuth
{
    public static void AddKeycloakAuthConfiguration(this IServiceCollection services, IConfigurationManager configuration)
    {
        var authenticationOptions = configuration
                                    .GetSection(KeycloakAuthenticationOptions.Section)
                                    .Get<KeycloakAuthenticationOptions>();

        services.AddKeycloakAuthentication(authenticationOptions!, options =>
        {
            options.Authority = "http://localhost:8080/realms/myrealm/";
            options.Events = new JwtBearerEvents
            {
                OnMessageReceived = context =>
                {
                    var accessToken = context.Request.Query["access_token"];

                    var path = context.HttpContext.Request.Path;
                    if (!string.IsNullOrEmpty(accessToken) &&
                        (path.StartsWithSegments("/hub")))
                    {
                        context.Token = accessToken;
                    }
                    return Task.CompletedTask;
                }
            };
        });

        var authorizationOptions = configuration
                                    .GetSection(KeycloakProtectionClientOptions.Section)
                                    .Get<KeycloakProtectionClientOptions>();

        services.AddKeycloakAuthorization(authorizationOptions!);

        var adminClientOptions = configuration
                                    .GetSection(KeycloakAdminClientOptions.Section)
                                    .Get<KeycloakAdminClientOptions>();

        services.AddKeycloakAdminHttpClient(adminClientOptions!);
    }

    public static void AddUserRequestContext(this IServiceCollection services)
    {
        services.AddTransient(provider =>
        {
            var httpContextAccessor = provider.GetRequiredService<IHttpContextAccessor>();
            var user = httpContextAccessor.HttpContext?.User;

            var userId = user?.Claims.FirstOrDefault(c => c.Properties.Any(p => p.Value == "sub"))?.Value;
            var userName = user?.Claims.FirstOrDefault(c => c.Properties.Any(p => p.Value == "name"))?.Value;
            var givenName = user?.Claims.FirstOrDefault(c => c.Properties.Any(p => p.Value == "given_name"))?.Value;
            var email = user?.Claims.FirstOrDefault(c => c.Properties.Any(p => p.Value == "email"))?.Value;

            return new UserRequestContext(userId, userName ?? givenName, email);
        });
    }
}

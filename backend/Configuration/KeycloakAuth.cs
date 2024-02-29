using Keycloak.AuthServices.Authentication;
using Keycloak.AuthServices.Authorization;
using Keycloak.AuthServices.Sdk.Admin;

namespace backend.Configuration;

public static class KeycloakAuth
{
    public static void AddKeycloakAuthConfiguration(this IServiceCollection services, IConfigurationManager configuration)
    {
        var authenticationOptions = configuration
                                    .GetSection(KeycloakAuthenticationOptions.Section)
                                    .Get<KeycloakAuthenticationOptions>();

        services.AddKeycloakAuthentication(authenticationOptions!);

        var authorizationOptions = configuration
                                    .GetSection(KeycloakProtectionClientOptions.Section)
                                    .Get<KeycloakProtectionClientOptions>();

        services.AddKeycloakAuthorization(authorizationOptions!);

        var adminClientOptions = configuration
                                    .GetSection(KeycloakAdminClientOptions.Section)
                                    .Get<KeycloakAdminClientOptions>();

        services.AddKeycloakAdminHttpClient(adminClientOptions!);
    }   
}

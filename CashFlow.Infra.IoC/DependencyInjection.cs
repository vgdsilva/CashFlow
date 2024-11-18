using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CashFlow.Infra.IoC;

public static class DependencyInjection
{
    public static IServiceCollection AddDatabaseContext(this IServiceCollection services, IConfiguration configuration)
    {
        // Regras.Application.IniciaContextoComumWeb(new Contexto(), connectionString);

        return services;
    }

    public static IServiceCollection AddAuthenticationConfig(this IServiceCollection services,
        IConfiguration configuration)
    {
        return services;
    }
}
using Scrutor;
using Facturacion.Models.Attributes;

namespace Facturacion.Services;

public static class RegisterServices
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.Scan(scan => scan
        .FromCallingAssembly()
        .AddClasses(@class => @class.WithAttribute<InjectAsTransientAttribute>())
        .UsingRegistrationStrategy(RegistrationStrategy.Skip)
        .AsSelfWithInterfaces()
        .WithTransientLifetime());

        return services;
    }

}

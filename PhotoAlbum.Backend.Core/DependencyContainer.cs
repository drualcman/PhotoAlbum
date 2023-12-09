namespace Microsoft.Extensions.DependencyInjection;
public static class DependencyContainer
{
    public static IServiceCollection AddCoreServices(this IServiceCollection services)
    {
        services.AddScoped<IGetPhotosInputPort, GetPhotosInteractor>();
        return services;
    }
}

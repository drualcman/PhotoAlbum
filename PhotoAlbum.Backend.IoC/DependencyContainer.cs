namespace Microsoft.Extensions.DependencyInjection;
public static class DependencyContainer
{
    public static IServiceCollection AddPhotoAlbumServices(this IServiceCollection services)
    {
        services.AddCoreServices();
        services.AddRepositoryServices();
        return services;
    }
}

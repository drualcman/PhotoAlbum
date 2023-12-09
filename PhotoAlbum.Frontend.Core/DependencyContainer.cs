namespace Microsoft.Extensions.DependencyInjection;
public static class DependencyContainer
{
    public static IServiceCollection AddPhotoAlbumCoreServices(this IServiceCollection services,
        Action<HttpClient> configureClient)
    {
        services.AddPhotoAlbumViewModels();
        services.AddHttpClient<IGetPhotosGateway, GetPhotosGateway>(configureClient);
        return services;
    }
    public static IServiceCollection AddPhotoAlbumViewModels(this IServiceCollection services)
    {
        services.TryAddScoped<GetPhotosViewModel>();
        return services;
    }
}

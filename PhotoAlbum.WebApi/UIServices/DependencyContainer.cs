using PhotoAlbum.Entities.UI.Services.Interfaces;
using PhotoAlbum.WebApi.UIServices;

namespace Microsoft.Extensions.DependencyInjection;
public static class DependencyContainer
{
    public static IServiceCollection AddUIServices(this IServiceCollection services)
    {                                                                  
        services.AddScoped<IGetPhotosGateway, GetPhotosGateway>();
        return services;
    }
}

namespace Microsoft.AspNetCore.Builder;
public static class EndpointsContainer
{
    public static WebApplication MapPhotosEndpoints(this WebApplication app)
    {
        app.UseGetPhotosController();
        return app;
    }
}

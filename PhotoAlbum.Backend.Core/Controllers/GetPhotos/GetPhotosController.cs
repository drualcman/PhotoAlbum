namespace Microsoft.AspNetCore.Builder;
public static class GetPhotosController
{
    public static WebApplication UseGetPhotosController(this WebApplication app)
    {
        app.MapGet(Endpoints.GetPhotos, GetPhotosAsync);
        return app;
    }

    public static Task<IEnumerable<PhotoDto>> GetPhotosAsync(IGetPhotosInputPort inputPort) =>
        inputPort.GetPhotosAsync();
}

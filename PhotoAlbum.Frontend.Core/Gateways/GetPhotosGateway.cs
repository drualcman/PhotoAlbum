namespace PhotoAlbum.Frontend.Core.Gateways;
internal class GetPhotosGateway(HttpClient Client) : IGetPhotosGateway
{
    public async Task<IEnumerable<PhotoDto>> GetPhotosAsync() =>
        await Client.GetFromJsonAsync<IEnumerable<PhotoDto>>(Endpoints.GetPhotos);
}
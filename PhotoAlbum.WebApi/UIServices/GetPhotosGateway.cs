using PhotoAlbum.Backend.BusinessObjects.Interfaces.GetPhotos;
using PhotoAlbum.Entities.Dtos;
using PhotoAlbum.Entities.UI.Services.Interfaces;

namespace PhotoAlbum.WebApi.UIServices;

internal class GetPhotosGateway(IGetPhotosInputPort InputPort) : IGetPhotosGateway
{
    public async Task<IEnumerable<PhotoDto>> GetPhotosAsync() =>
        await GetPhotosController.GetPhotosAsync(InputPort); 

    //public async Task<IEnumerable<PhotoDto>> GetPhotosAsync() =>
    //    await Task.FromResult(default(IEnumerable<PhotoDto>));
}

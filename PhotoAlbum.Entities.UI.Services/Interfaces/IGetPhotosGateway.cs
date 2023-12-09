namespace PhotoAlbum.Entities.UI.Services.Interfaces;
public interface IGetPhotosGateway
{
    Task<IEnumerable<PhotoDto>> GetPhotosAsync();
}

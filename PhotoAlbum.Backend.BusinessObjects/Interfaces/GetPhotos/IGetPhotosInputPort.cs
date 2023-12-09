namespace PhotoAlbum.Backend.BusinessObjects.Interfaces.GetPhotos;
public interface IGetPhotosInputPort
{
    Task<IEnumerable<PhotoDto>> GetPhotosAsync();
}

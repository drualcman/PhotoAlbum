namespace PhotoAlbum.Backend.BusinessObjects.Common;
public interface IQueriesRepository
{
    Task<IEnumerable<PhotoDto>> GetPhotosAsync();
}

namespace PhotoAlbum.Backend.Core.UseCases.GetPhotos;
internal class GetPhotosInteractor(IQueriesRepository Repopsitory) : IGetPhotosInputPort
{
    public Task<IEnumerable<PhotoDto>> GetPhotosAsync()  =>
        Repopsitory.GetPhotosAsync();
}

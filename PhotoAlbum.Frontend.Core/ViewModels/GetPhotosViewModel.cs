namespace PhotoAlbum.Frontend.Core.ViewModels;
internal class GetPhotosViewModel(IGetPhotosGateway Gateway)
{
    public IEnumerable<PhotoDto> Photos {  get; set; }
    public async Task<IEnumerable<PhotoDto>> GetPhotosAsync()
    {
        if (Photos == null)
        {
            Photos = await Gateway.GetPhotosAsync();
        }
        return Photos;
    }
}
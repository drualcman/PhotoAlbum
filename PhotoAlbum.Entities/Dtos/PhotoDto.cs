namespace PhotoAlbum.Entities.Dtos;
public class PhotoDto(string url, string description, string user)
{
    public string Url { get; } = url;
    public string Description { get; } = description;
    public string User { get; } = user;
}

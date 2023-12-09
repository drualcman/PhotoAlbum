namespace PhotoAlbum.Frontend.Core.Components;
public partial class CollectionView<TModel> : ComponentBase
{
    [Parameter] public Func<Task<IEnumerable<TModel>>> Loader { get; set; }
    [Parameter] public RenderFragment Loading { get; set; }
    [Parameter] public RenderFragment Empty { get; set; }
    [Parameter] public RenderFragment<TModel> Item { get; set; }

    IEnumerable<TModel> Collection;

    protected override async Task OnParametersSetAsync() 
    {
        Collection = await Loader();
    }
}

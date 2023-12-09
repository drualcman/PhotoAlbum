using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddPhotoAlbumCoreServices(httpClient =>
    httpClient.BaseAddress = new Uri(builder.Configuration["WebApiUri"]));

await builder.Build().RunAsync();

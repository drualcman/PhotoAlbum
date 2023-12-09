using PhotoAlbum.Entities.UI.Services.Interfaces;
using PhotoAlbum.WebApi.UIServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddPhotoAlbumServices();
builder.Services.AddCors(setup => 
{
    setup.AddDefaultPolicy(policy => 
    {
        policy.AllowAnyHeader();
        policy.AllowAnyMethod();
        policy.AllowAnyOrigin();
    });
});
builder.Services.AddRazorPages();

builder.Services.AddUIServices();
builder.Services.AddPhotoAlbumViewModels();

var app = builder.Build();

// Configure the HTTP request pipeline.
if(app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseWebAssemblyDebugging();  
}
else
{
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();
app.MapRazorPages();
//app.UseRouting();

app.MapPhotosEndpoints();
app.UseCors();

app.MapFallbackToPage("/_Host");
//app.MapFallbackToFile("index.html");

app.Run();

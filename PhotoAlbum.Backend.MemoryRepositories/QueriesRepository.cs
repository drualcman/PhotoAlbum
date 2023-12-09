namespace PhotoAlbum.Backend.MemoryRepositories;
internal class QueriesRepository : IQueriesRepository
{
    IReadOnlyCollection<PhotoDto> Photos = [
            new PhotoDto("https://scontent.fpbc6-1.fna.fbcdn.net/v/t39.30808-6/407313550_10161278555964583_5014157020218226616_n.jpg?stp=cp6_dst-jpg&_nc_cat=110&ccb=1-7&_nc_sid=dd5e9f&_nc_ohc=-vqGXRBZZswAX_l4bCW&_nc_ht=scontent.fpbc6-1.fna&oh=00_AfCK3Sb2ae3z28TR5drjt9EnZSNKflp-t0R5QufHcCIraw&oe=6574996A",
                "El buen DrUalcman Programacion presentado Blazor en el #NETConf2023Puebla", "MSMDotnet"),
        new PhotoDto("https://scontent.fpbc6-1.fna.fbcdn.net/v/t39.30808-6/407172543_10161278697079583_820603332000029373_n.jpg?stp=cp6_dst-jpg&_nc_cat=111&ccb=1-7&_nc_sid=dd5e9f&_nc_ohc=YMP6zn61CgIAX9HxO8S&_nc_ht=scontent.fpbc6-1.fna&oh=00_AfAkywch_vpvm3RUyKEgaFH_9E1bKsWIh61aihLPf4Az6g&oe=65752E81",
                "Hybrid Blazor y .NET MAUI con Misael Cazarez y Bryan Oroxon en la #NETConf2023Puebla", "MSMDotnet"),
        new PhotoDto("https://scontent.fpbc6-1.fna.fbcdn.net/v/t39.30808-6/407326073_10161278772139583_6569350598906889718_n.jpg?stp=cp6_dst-jpg&_nc_cat=110&ccb=1-7&_nc_sid=dd5e9f&_nc_ohc=Htv7-Rd-21EAX9DEySU&_nc_ht=scontent.fpbc6-1.fna&oh=00_AfCfQdVgIZbh7JbFeUHy0H4BuiLK2anMJlkfrNFN4Xf9Hw&oe=657467B2",
                "Azure Open AI con Jesús Gil Velasco y Humberto Jaimes en el #NETConf2023Puebla", "MSMDotnet"),
        new PhotoDto("https://scontent.fpbc6-1.fna.fbcdn.net/v/t39.30808-6/407578011_10161278910984583_4042017938434616415_n.jpg?stp=cp6_dst-jpg&_nc_cat=100&ccb=1-7&_nc_sid=dd5e9f&_nc_ohc=EpqAW7PKZTYAX9DLfu7&_nc_ht=scontent.fpbc6-1.fna&oh=00_AfCYv7SEVL_YL2oBvleM20sAXXpX6_BlZuc5zbazDadneQ&oe=65757452",
                "Observabilidad, la etapa olvidada de nuestros proyectos, por Amin Espinoza en el #NETConf2023Puebla", "MSMDotnet"),
        new PhotoDto("https://scontent.fpbc6-1.fna.fbcdn.net/v/t39.30808-6/407438445_10161279332989583_1493494724253412887_n.jpg?stp=cp6_dst-jpg&_nc_cat=109&ccb=1-7&_nc_sid=dd5e9f&_nc_ohc=unaWetCMW-oAX89rAiF&_nc_ht=scontent.fpbc6-1.fna&oh=00_AfD8kAWxI5oiHaXhPfSQd-spnNYIB65frJQF1yGKI58VdA&oe=65754534",
                "En la última charla con los muy buenos discípulos de Benjamín Romero en la #NETConf2023Puebla", "MSMDotnet")
        ];

    public async Task<IEnumerable<PhotoDto>> GetPhotosAsync() => 
        await Task.FromResult(Photos);
}

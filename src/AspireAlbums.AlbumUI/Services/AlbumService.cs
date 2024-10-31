namespace AspireAlbums.AlbumUI.Services
{
    public class AlbumService(HttpClient httpClient)
    {
        public async Task<IEnumerable<Album>> GetAlbumsAsync(CancellationToken cancellationToken = default)
        {
            var result = await httpClient.GetFromJsonAsync<IEnumerable<Album>>("/albums", cancellationToken);
            return result ?? [];
        }
    }

    public record Album(int Id, string Title, string Artist, double Price, string Image_url);
}

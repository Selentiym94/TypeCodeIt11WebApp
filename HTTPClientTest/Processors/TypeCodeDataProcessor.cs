using TypeCodeIt11.Logic.Interfaces;
using TypeCodeIt11.Logic.Models;

namespace TypeCodeIt11.Logic.Processors
{
    public class TypeCodeDataProcessor
    {
        private readonly ITypeCodeClient _client;

        public TypeCodeDataProcessor(ITypeCodeClient client)
        {
            _client = client;
        }
        public async Task<TypeCodeData> Get(string userName)
        {
            TypeCodeData result = new TypeCodeData();
            result.User = (await _client.GetUsers(userName)).FirstOrDefault();
            if(result.User != null)
            {
                result.Notes = await _client.GetNotes(result.User.Id);
                result.AlbumDatas = await GetAlbumDatas(result.User.Id);
                result.PostDatas = await GetPostDatas(result.User.Id);
            }
            return result;
        }

        private async Task<List<AlbumDatas>> GetAlbumDatas(int userId)
        {
            List<AlbumDatas> results = new List<AlbumDatas>();
            List<Album> albums = await _client.GetAlbums(userId);
            foreach (var album in albums)
            {
                List<Photo> photos = await _client.GetPhotos(album.Id);
                AlbumDatas data = new AlbumDatas(album, photos);
                results.Add(data);
            }
            return results;
        }
        private async Task<List<PostData>> GetPostDatas(int userId)
        {
            List<PostData> results = new List<PostData>();
            List<Post> posts = await _client.GetPost(userId);
            foreach (var post in posts)
            {
                List<Comment> comments = await _client.GetComments(post.Id);
                PostData data = new PostData(post, comments);
                results.Add(data);
            }
            return results;
        }
    }
}

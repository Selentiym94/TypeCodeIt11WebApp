using System.Text.Json;
using TypeCodeIt11.Logic.Interfaces;
using TypeCodeIt11.Logic.Models;
using TypeCodeIt11.Logic.Models.Requests;


namespace TypeCodeIt11.Logic.Processors
{
    public class TypeCodeClient : ITypeCodeClient
    {
        private readonly string _baseUrl;
        public TypeCodeClient(string baseUrl)
        {
            _baseUrl = baseUrl;
        }

        public async Task<List<Note>> GetNotes(int userId)
        {
            IRequestData data = new GetNotesRequest(userId);
            return await GetData<Note>(data);
        }
        public async Task<List<Album>> GetAlbums(int userId)
        {
            IRequestData data = new GetAlbumRequest(userId);
            return await GetData<Album>(data);
        }

        public async Task<List<Photo>> GetPhotos(int albumId)
        {
            IRequestData data = new GetPostRequest(albumId);
            return await GetData<Photo>(data);
        }

        public async Task<List<Comment>> GetComments(int postId)
        {
            IRequestData data = new GetCommentRequest(postId);
            return await GetData<Comment>(data);
        }

        public async Task<List<Post>> GetPost(int userID)
        {
            IRequestData data = new GetPostRequest(userID);
            return await GetData<Post>(data);
        }

        public async Task<List<User>> GetUsers(string name)
        {
            IRequestData data = new GetUserRequest(name);
            return await GetData<User>(data);
        }
        private async Task<List<TType>> GetData<TType>(IRequestData data)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = data.GetData();
                HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Get, $"{_baseUrl}/{url}");
                HttpResponseMessage response = await client.SendAsync(message);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<List<TType>>(content);
                }
            }
            return new List<TType>();





        }
    }
}

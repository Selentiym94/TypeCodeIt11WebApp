using HTTPClientTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using HTTPClientTest.Requests;

namespace HTTPClientTest
{
    public  class TypeCodeClient
    {
        private readonly string _baseUrl;

        public TypeCodeClient(string baseUrl)
        {
            _baseUrl = baseUrl;
        }

        public async Task<List<User>> GetUsers(IRequest request = null)
        {
            string path = "users" + (request == null ? string.Empty : $"?{request.GetRquestData()}");
            
            return await GetDataOrDefault<List<User>>(path).ConfigureAwait(false);
        }
        public async Task<User> GetUser(int id)
        {
            return await GetDataOrDefault<User>($"users/{id}").ConfigureAwait(false);
        }
        public async Task<List<Post>> GetPosts(IRequest request = null)
        {
            return await GetDataOrDefault<List<Post>>("posts").ConfigureAwait(false);
        }
        public async Task<Post> GetPost(int id)
        {
            return await GetDataOrDefault<Post>($"posts/{id}").ConfigureAwait(false);
        }


        private async Task<TType> GetDataOrDefault<TType>(string path)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpRequestMessage message = new HttpRequestMessage();
                message.Method = HttpMethod.Get;
                message.RequestUri = new Uri($"{_baseUrl}/{path}");

                HttpResponseMessage response = await client.SendAsync(message).ConfigureAwait(false);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    TType data = JsonSerializer.Deserialize<TType>(content);
                    return data;
                }
                return default;
            }
        }

    }
}

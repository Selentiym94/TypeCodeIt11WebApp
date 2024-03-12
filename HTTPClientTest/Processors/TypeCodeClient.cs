using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;
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

        public Task<List<Comment>> GetComments(int postId)
        {
           IRequestData data = new Get
        }

        public async  Task<List<Post>> GetPost(int userID)
        {
            IRequestData data = new GetPostRequest(userID);
            return await GetData<Post>(data);
        }

        public async Task <List<User>> GetUsers(string name)
        {
            IRequestData data = new GetUserRequest(name);
            return await GetData<User>(data);
        }
        private async Task<List<TType>> GetData<TType>(IRequestData data)
        {
            using(HttpClient client = new HttpClient())
            {
                string url = data.GetData();
                HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Get, $"{_baseUrl}/{url}");
                HttpResponseMessage response = await client.SendAsync(message);
                if(response.IsSuccessStatusCode) 
                {
                    string content = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<List<TType>>(content);
                }
            }
            return new List<TType>();





        }
    }
}

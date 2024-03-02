using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using TypeCodeIt11.Logic.Interfaces;
using TypeCodeIt11.Logic.Models;

namespace TypeCodeIt11.Logic.Processors
{
    public class TypeCodeClient : ITypeCodeClient
    {
        private readonly string _baseUrl;
        public TypeCodeClient(string baseUrl)
        {
            _baseUrl = baseUrl;
        }
        
        public List<User> GetUsers(string name)
        {
            throw new NotImplementedException();
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

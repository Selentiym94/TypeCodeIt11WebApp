using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HTTPClientTest.Models
{
    public  class Post
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        
        [JsonPropertyName("userId")]
        public int UserId { get; set; }
       
        [JsonPropertyName("title")]
        public string Tittle { get; set; }
        
        [JsonPropertyName("body")]
        public string Body { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TypeCodeIt11.Logic.Models
{
    public class Note
    {
        [JsonPropertyName("userId")]
        public string UserId { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("completed")]
        public bool Completed { get; set; }

    }
}

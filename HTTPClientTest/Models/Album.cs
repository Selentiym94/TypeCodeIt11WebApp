using System.Text.Json.Serialization;

namespace TypeCodeIt11.Logic.Models
{
    public class Album
    {

        [JsonPropertyName("userId")]
        public int UserID { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}

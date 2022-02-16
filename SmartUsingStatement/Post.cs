using System.Text.Json.Serialization;

namespace SmartUsingStatements
{
    internal class Post
    {
        [JsonPropertyName("userId")]
        public int UserId { get; init; }
        [JsonPropertyName("id")]
        public int Id { get; init; }
        [JsonPropertyName("title")]
        public string Title { get; init; }
        [JsonPropertyName("body")]
        public string Body { get; init; }
    }
}

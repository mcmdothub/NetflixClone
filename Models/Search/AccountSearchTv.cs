using Newtonsoft.Json;

namespace DotnetFlix.Objects.Search
{
    public class AccountSearchTv : SearchTv
    {
        [JsonProperty("rating")]
        public float Rating { get; set; }
    }
}
using Newtonsoft.Json;

namespace DotnetFlix.Objects.Search
{
    public class AccountSearchTvEpisode : SearchTvEpisode
    {
        [JsonProperty("rating")]
        public double Rating { get; set; }
    }
}
using Newtonsoft.Json;

namespace DotnetFlix.Objects.Search
{
    public class SearchTvShowWithRating : SearchTv
    {
        [JsonProperty("rating")]
        public double Rating { get; set; }
    }
}
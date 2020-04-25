using Newtonsoft.Json;

namespace DotnetFlix.Objects.TvShows
{
    public class TvAccountState
    {
        [JsonProperty("rating")]
        public double? Rating { get; set; }
    }
}
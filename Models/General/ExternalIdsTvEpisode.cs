using Newtonsoft.Json;

namespace DotnetFlix.Objects.General
{
    public class ExternalIdsTvEpisode : ExternalIds
    {
        [JsonProperty("imdb_id")]
        public string ImdbId { get; set; }

        [JsonProperty("tvdb_id")]
        public string TvdbId { get; set; }
    }
}
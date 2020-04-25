using Newtonsoft.Json;

namespace DotnetFlix.Objects.General
{
    public class ExternalIdsTvSeason : ExternalIds
    {
        [JsonProperty("tvdb_id")]
        public string TvdbId { get; set; }
    }
}
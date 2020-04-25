using Newtonsoft.Json;
using DotnetFlix.Utilities.Converters;

namespace DotnetFlix.Objects.Changes
{
    public class ChangesListItem
    {
        [JsonProperty("adult")]
        public bool? Adult { get; set; }

        [JsonProperty("id")]
        [JsonConverter(typeof(TmdbNullIntAsZero))]
        public int Id { get; set; }
    }
}
using Newtonsoft.Json;

namespace DotnetFlix.Objects.General
{
    public class AlternativeName
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
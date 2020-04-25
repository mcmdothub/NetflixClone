using Newtonsoft.Json;

namespace DotnetFlix.Objects.Search
{
    public class SearchKeyword
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
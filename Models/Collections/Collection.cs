using System.Collections.Generic;
using Newtonsoft.Json;
using DotnetFlix.Objects.General;
using DotnetFlix.Objects.Search;

namespace DotnetFlix.Objects.Collections
{
    public class Collection
    {
        [JsonProperty("backdrop_path")]
        public string BackdropPath { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("images")]
        public Images Images { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("overview")]
        public string Overview { get; set; }

        [JsonProperty("parts")]
        public List<SearchMovie> Parts { get; set; }

        [JsonProperty("poster_path")]
        public string PosterPath { get; set; }
    }
}

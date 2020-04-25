using System.Collections.Generic;
using Newtonsoft.Json;
using DotnetFlix.Objects.General;

namespace DotnetFlix.Objects.Movies
{
    public class KeywordsContainer
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("keywords")]
        public List<Keyword> Keywords { get; set; }
    }
}
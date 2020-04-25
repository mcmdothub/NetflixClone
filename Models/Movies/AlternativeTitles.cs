using System.Collections.Generic;
using Newtonsoft.Json;
using DotnetFlix.Objects.General;

namespace DotnetFlix.Objects.Movies
{
    public class AlternativeTitles
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("titles")]
        public List<AlternativeTitle> Titles { get; set; }
    }
}
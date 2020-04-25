using System.Collections.Generic;
using Newtonsoft.Json;
using DotnetFlix.Objects.General;

namespace DotnetFlix.Objects.Movies
{
    public class Credits
    {
        [JsonProperty("cast")]
        public List<Cast> Cast { get; set; }

        [JsonProperty("crew")]
        public List<Crew> Crew { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
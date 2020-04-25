using System.Collections.Generic;
using Newtonsoft.Json;
using DotnetFlix.Objects.General;

namespace DotnetFlix.Objects.TvShows
{
    public class NetworkLogos
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("logos")]
        public List<ImageData> Logos { get; set; }
    }
}
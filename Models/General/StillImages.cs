using System.Collections.Generic;
using Newtonsoft.Json;

namespace DotnetFlix.Objects.General
{
    public class StillImages
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("stills")]
        public List<ImageData> Stills { get; set; }
    }
}
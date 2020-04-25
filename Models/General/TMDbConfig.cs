using System.Collections.Generic;
using Newtonsoft.Json;

namespace DotnetFlix.Objects.General
{
    public class TMDbConfig
    {
        [JsonProperty("change_keys")]
        public List<string> ChangeKeys { get; set; }

        [JsonProperty("images")]
        public ConfigImageTypes Images { get; set; }
    }
}
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DotnetFlix.Objects.Configuration
{
    public class APIConfiguration
    {
        [JsonProperty("images")]
        public APIConfigurationImages Images;

        [JsonProperty("change_keys")]
        public List<string> ChangeKeys { get; set; }
    }
}

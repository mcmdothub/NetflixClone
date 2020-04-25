using Newtonsoft.Json;

namespace DotnetFlix.Objects.Account
{
    public class Gravatar
    {
        [JsonProperty("hash")]
        public string Hash { get; set; }
    }
}
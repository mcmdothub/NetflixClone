using Newtonsoft.Json;

namespace DotnetFlix.Objects.Account
{
    public class Avatar
    {
        [JsonProperty("gravatar")]
        public Gravatar Gravatar { get; set; }
    }
}
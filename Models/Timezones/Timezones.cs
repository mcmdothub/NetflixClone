using System.Collections.Generic;
using Newtonsoft.Json;

namespace DotnetFlix.Objects.Timezones
{
    public class Timezones
    {
        [JsonProperty("list")]
        public Dictionary<string, List<string>> List { get; set; }
    }
}
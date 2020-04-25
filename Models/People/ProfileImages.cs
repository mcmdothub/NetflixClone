using System.Collections.Generic;
using Newtonsoft.Json;
using DotnetFlix.Objects.General;

namespace DotnetFlix.Objects.People
{
    public class ProfileImages
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("profiles")]
        public List<ImageData> Profiles { get; set; }
    }
}
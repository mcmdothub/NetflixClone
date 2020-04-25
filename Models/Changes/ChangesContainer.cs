using System.Collections.Generic;
using Newtonsoft.Json;

namespace DotnetFlix.Objects.Changes
{
    public class ChangesContainer
    {
        [JsonProperty("changes")]
        public List<Change> Changes { get; set; }
    }
}
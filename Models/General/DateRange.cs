using System;
using Newtonsoft.Json;

namespace DotnetFlix.Objects.General
{
    public class DateRange
    {
        [JsonProperty("maximum")]
        public DateTime Maximum { get; set; }

        [JsonProperty("minimum")]
        public DateTime Minimum { get; set; }
    }
}
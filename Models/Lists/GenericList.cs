using System.Collections.Generic;
using Newtonsoft.Json;
using DotnetFlix.Objects.Search;

namespace DotnetFlix.Objects.Lists
{
    public class GenericList : List
    {
        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }

        [JsonProperty("items")]
        public List<SearchMovie> Items { get; set; }
    }
}
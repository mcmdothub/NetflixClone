using Newtonsoft.Json;
using DotnetFlix.Objects.General;

namespace DotnetFlix.Objects.Lists
{
    public class AccountList : List
    {
        [JsonProperty("list_type")]
        public MediaType ListType { get; set; }
    }
}
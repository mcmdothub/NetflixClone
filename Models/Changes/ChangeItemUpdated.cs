using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DotnetFlix.Objects.Changes
{
    public class ChangeItemUpdated : ChangeItemBase
    {
        public ChangeItemUpdated()
        {
            Action = ChangeAction.Updated;
        }

        [JsonProperty("original_value")]
        public JToken OriginalValue { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }
    }
}
using Newtonsoft.Json;
using DotnetFlix.Utilities;
using DotnetFlix.Utilities.Converters;

namespace DotnetFlix.Objects.Changes
{
    [JsonConverter(typeof(EnumStringValueConverter))]
    public enum ChangeAction
    {
        Unknown,

        [EnumValue("added")]
        Added = 1,

        [EnumValue("created")]
        Created = 2,

        [EnumValue("updated")]
        Updated = 3,

        [EnumValue("deleted")]
        Deleted = 4,

        [EnumValue("destroyed")]
        Destroyed = 5
    }
}
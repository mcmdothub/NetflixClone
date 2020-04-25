using Newtonsoft.Json;
using DotnetFlix.Utilities;
using DotnetFlix.Utilities.Converters;

namespace DotnetFlix.Objects.General
{
    [JsonConverter(typeof(EnumStringValueConverter))]
    public enum MediaType
    {
        Unknown,

        [EnumValue("movie")]
        Movie = 1,

        [EnumValue("tv")]
        Tv = 2,

        [EnumValue("person")]
        Person = 3
    }
}
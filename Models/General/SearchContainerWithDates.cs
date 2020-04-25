using Newtonsoft.Json;

namespace DotnetFlix.Objects.General
{
    public class SearchContainerWithDates<T> : SearchContainer<T>
    {
        [JsonProperty("dates")]
        public DateRange Dates { get; set; }
    }
}
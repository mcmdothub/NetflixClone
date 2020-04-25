using Newtonsoft.Json;

namespace DotnetFlix.Objects.General
{
    public class ImagesWithId : Images
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
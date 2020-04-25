using System.Collections.Generic;
using Newtonsoft.Json;
using DotnetFlix.Objects.General;

namespace DotnetFlix.Objects.Genres
{
    public class GenreContainer
    {
        [JsonProperty("genres")]
        public List<Genre> Genres { get; set; }
    }
}
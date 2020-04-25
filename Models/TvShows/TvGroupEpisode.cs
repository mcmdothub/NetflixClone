using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using DotnetFlix.Objects.General;

namespace DotnetFlix.Objects.TvShows
{
    public class TvGroupEpisode : TvEpisodeBase
    {
        [JsonProperty("order")]
        public int Order { get; set; }
    }
}
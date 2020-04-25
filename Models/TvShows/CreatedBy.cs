﻿using Newtonsoft.Json;
using DotnetFlix.Objects.People;

namespace DotnetFlix.Objects.TvShows
{
    public class CreatedBy
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("credit_id")]
        public string CreditId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("gender")]
        public PersonGender Gender { get; set; }

        [JsonProperty("profile_path")]
        public string ProfilePath { get; set; }
    }
}
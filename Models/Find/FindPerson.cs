using Newtonsoft.Json;
using DotnetFlix.Objects.Search;
using DotnetFlix.Objects.People;

namespace DotnetFlix.Objects.Find
{
    public class FindPerson : SearchPerson
    {
        [JsonProperty("gender")]
        public PersonGender Gender { get; set; }

        [JsonProperty("known_for_department")]
        public string KnownForDepartment { get; set; }
    }
}
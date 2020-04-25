using DotnetFlix.Utilities;

namespace DotnetFlix.Objects.Find
{
    public enum FindExternalSource
    {
        [EnumValue("imdb_id")]
        Imdb,

        [EnumValue("tvdb_id")]
        TvDb
    }
}
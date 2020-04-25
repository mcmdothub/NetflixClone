using DotnetFlix.Utilities;

namespace DotnetFlix.Objects.Account
{
    public enum AccountSortBy
    {
        Undefined = 0,
        [EnumValue("created_at")]
        CreatedAt = 1,
    }
}

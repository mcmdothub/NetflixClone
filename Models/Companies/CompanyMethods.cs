using System;
using DotnetFlix.Utilities;

namespace DotnetFlix.Objects.Companies
{
    [Flags]
    public enum CompanyMethods
    {
        [EnumValue("Undefined")]
        Undefined = 0,
        [EnumValue("movies")]
        Movies = 1
    }
}
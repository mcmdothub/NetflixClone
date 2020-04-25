using System;
using DotnetFlix.Utilities;

namespace DotnetFlix.Objects.Collections
{
    [Flags]
    public enum CollectionMethods
    {
        [EnumValue("Undefined")]
        Undefined = 0,
        [EnumValue("images")]
        Images = 1
    }
}
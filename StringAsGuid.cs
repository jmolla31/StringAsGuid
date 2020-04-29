using System;

namespace System
{
    public static class StringAsGuid
    {
        public static Guid AsGuid(this string @string)
        {
            if (@string == null || @string.Length == 0) return Guid.Empty;

            _ = Guid.TryParse(@string, out Guid parsedGuid);

            return parsedGuid;
        }
    }
}

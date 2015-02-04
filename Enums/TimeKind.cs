using System;
using System.Runtime.InteropServices;

namespace Custom.Enums
{
    /// <summary>
    /// Specifies whether a <see cref="T:Custom.Enums.TimeKind"/> object represents a local time, a Coordinated Universal Time (UTC), or is not specified as either local time or UTC.
    /// </summary>
    /// <filterpriority>2</filterpriority>
    [ComVisible(true)]
    [Serializable]
    public enum TimeKind
    {
        Unspecified,
        Utc,
        Local,
    }
}

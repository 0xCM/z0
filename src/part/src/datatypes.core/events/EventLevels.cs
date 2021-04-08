//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [ApiComplete]
    public readonly struct EventLevels
    {
        public static EventLevel Babble => LogLevel.Babble;

        public static EventLevel Status => LogLevel.Status;

        public static EventLevel Trace => LogLevel.Trace;

        public static EventLevel Warning => LogLevel.Warning;

        public static EventLevel Error => LogLevel.Error;
    }
}

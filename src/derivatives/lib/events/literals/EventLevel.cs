//-----------------------------------------------------------------------------
// Derivative Work
// Origin:    : https://github.com/microsoft/scalar
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.X.Events
{
    using System;
    using System.Collections.Generic;

    // The default EventLevel is Verbose, which does not go to log files by default.
    // If you want to log to a file, you need to raise EventLevel to at least Informational
    public enum EventLevel
    {
        LogAlways = 0,

        Critical = 1,

        Error = 2,

        Warning = 3,

        Informational = 4,

        Verbose = 5
    }
}
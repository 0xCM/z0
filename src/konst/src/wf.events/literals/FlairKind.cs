//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public enum FlairKind : byte
    {
        None = LogLevel.None,

        Created = LogLevel.Babble,

        Disposed = LogLevel.Babble,

        Running = ConsoleColor.Cyan,

        Ran = ConsoleColor.Magenta,

        Processed = ConsoleColor.Magenta,

        Babble = LogLevel.Babble,

        Status = LogLevel.Status,

        Trace = LogLevel.Trace,

        Warning = LogLevel.Warning,

        Data = ConsoleColor.DarkCyan,

        Error = LogLevel.Error,
    }
}
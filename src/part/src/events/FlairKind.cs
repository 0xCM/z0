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

        Created = ConsoleColor.DarkGray,

        Disposed = ConsoleColor.DarkGray,

        Running = ConsoleColor.Cyan,

        Ran = ConsoleColor.Magenta,

        Processed = ConsoleColor.Magenta,

        Babble = ConsoleColor.DarkGray,

        Status = ConsoleColor.Green,

        Trace = ConsoleColor.DarkMagenta,

        Warning = ConsoleColor.Yellow,

        Data = ConsoleColor.DarkCyan,

        Error = ConsoleColor.Red,
    }
}
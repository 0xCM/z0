//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public enum FlairKind
    {
        Unspecified = ConsoleColor.White,

        Initializing = ConsoleColor.DarkGray,

        Initialized = ConsoleColor.DarkGray,

        Created = ConsoleColor.Blue,

        Running = ConsoleColor.Magenta,

        Ran = ConsoleColor.Cyan,

        Warning = ConsoleColor.Yellow,

        Error = ConsoleColor.Red,

        Disposed = ConsoleColor.Blue,

        Status = ConsoleColor.Green,

        Blue = ConsoleColor.Blue,

        DataRow = ConsoleColor.DarkCyan,

        DarkMagenta = ConsoleColor.DarkMagenta,

        Trace = ConsoleColor.DarkMagenta,

        Reserved1 = ConsoleColor.DarkYellow,

        Reserved2 = ConsoleColor.DarkRed,
    }
}
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

        Created = ConsoleColor.DarkBlue,

        Running = ConsoleColor.Magenta,

        Ran = ConsoleColor.Cyan,

        Warning = ConsoleColor.Yellow,

        Error = ConsoleColor.Red,

        Disposed = ConsoleColor.DarkBlue,

        Status = ConsoleColor.Green,

        Blue = ConsoleColor.Blue,

        DarkCyan = ConsoleColor.DarkCyan,

        DarkMagenta = ConsoleColor.DarkMagenta,

        Reserved0 = ConsoleColor.DarkGreen,

        Reserved1 = ConsoleColor.DarkYellow,

        Reserved2 = ConsoleColor.DarkRed,
    }
}
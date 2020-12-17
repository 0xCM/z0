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

        Created = ConsoleColor.Blue,

        Running = ConsoleColor.Cyan,

        Ran = ConsoleColor.Magenta,

        Processed = ConsoleColor.Blue,

        Warning = ConsoleColor.Yellow,

        Error = ConsoleColor.Red,

        Babble = ConsoleColor.DarkGray,

        Disposed = ConsoleColor.Gray,

        Status = ConsoleColor.Cyan,

        Data = ConsoleColor.DarkCyan,

        Trace = ConsoleColor.DarkMagenta,
    }
}
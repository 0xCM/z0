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

        Babble = MsgFlair.Babble,

        Status = MsgFlair.Status,

        Trace = MsgFlair.Trace,

        Warning = MsgFlair.Warning,

        Error = MsgFlair.Error,

        Creating = ConsoleColor.DarkGray,

        Created = ConsoleColor.DarkGray,

        Disposed = ConsoleColor.DarkGray,

        Running = ConsoleColor.Cyan,

        Ran = ConsoleColor.Magenta,

        Processed = ConsoleColor.Magenta,

        Data = ConsoleColor.DarkGray,
    }
}
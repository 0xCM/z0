//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public enum EventKind : uint
    {
        None = 0,

        Babble = MsgLevel.Babble,

        Trace = MsgLevel.Trace,

        Status = MsgLevel.Status,

        Warn = MsgLevel.Warn,

        Error = MsgLevel.Error,

        Running,

        Ran,

        Emitting,

        Emitted,

        EmittingTable,

        EmittedTable,

        EmittingFile,

        EmittedFile,

        Created,

        Disposed,

        RunningCmd,

        CmdRan,

        Processing,

        Processed,

        ProcessingFile,

        ProcessedFile,

        Row,

        Rows,
    }
}
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

        Babble = 1,

        Trace = 2,

        Status = 4,

        Warn = 8,

        Error = 16,

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
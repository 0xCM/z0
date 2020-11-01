//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [Table(TableId, FieldCount)]
    public struct CmdExecStatus
    {
        public const string TableId = "tool.status";

        public const byte FieldCount = 6;

        public int Id;

        public DateTime StartTime;

        public bool HasExited;

        public DateTime ExitTime;

        public TimeSpan Duration;

        public int ExitCode;
    }
}
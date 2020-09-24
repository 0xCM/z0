//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [Table]
    public struct ToolStatus
    {
        public int Id;

        public DateTime StartTime;

        public bool HasExited;

        public DateTime ExitTime;

        public TimeSpan Duration;

        public int ExitCode;
    }   
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [Flags]
    public enum CaptureWorkflowOptions : byte
    {
        None = 0,

        EmitImm = 1,

        RebaseMembers = 2,

        EmitDump = 4,
    }
}
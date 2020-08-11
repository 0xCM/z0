//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;

    public struct FinalizerQueueSegment
    {
        public ulong Start { get; }
        
        public ulong End { get; }

        public FinalizerQueueSegment(ulong start, ulong end)
        {
            Start = start;
            End = end;        
        }
    }
}
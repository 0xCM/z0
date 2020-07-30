//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dac
{
    using System;
    using System.Runtime.InteropServices;

    public interface ISegmentBuilder
    {
        int LogicalHeap { get; }

        ulong Start { get; }

        ulong End { get; }

        ulong ReservedEnd { get; }

        ulong CommitedEnd { get; }

        ulong Gen0Start { get; }

        ulong Gen0Length { get; }

        ulong Gen1Start { get; }

        ulong Gen1Length { get; }

        ulong Gen2Start { get; }

        ulong Gen2Length { get; }

        bool IsLargeObjectSegment { get; }

        bool IsEphemeralSegment { get; }
    }
}
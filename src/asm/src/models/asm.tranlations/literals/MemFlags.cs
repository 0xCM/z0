//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Ice
{
    using System;

    [Flags]
    public enum MemFlags : ushort
    {
        ScaleMask = 0x00000003,

        DisplSizeShift = 0x00000002,

        DisplSizeMask = 0x00000007,

        SegmentPrefixShift = 0x00000005,

        SegmentPrefixMask = 0x00000007,

        Broadcast = 0x00008000,
    }
}
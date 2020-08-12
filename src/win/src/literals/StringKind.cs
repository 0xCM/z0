//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;

    public enum StringKind : byte
    {
        Plain = (byte)(StringHandleType.String >> HeapHandleType.OffsetBitCount),
        
        Virtual = (byte)(StringHandleType.VirtualString >> HeapHandleType.OffsetBitCount),
        
        WinRTPrefixed = (byte)(StringHandleType.WinRTPrefixedString >> HeapHandleType.OffsetBitCount),
        
        DotTerminated = (byte)(StringHandleType.DotTerminatedString >> HeapHandleType.OffsetBitCount),
    }
}
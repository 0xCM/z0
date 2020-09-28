//-----------------------------------------------------------------------------
// Derivative Work
// Origin:    : https://github.com/microsoft/scalar
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Derivatives.SRM
{
    public enum StringKind : byte
    {
        Plain = (byte)(StringHandleType.String >> HeapHandleType.OffsetBitCount),

        Virtual = (byte)(StringHandleType.VirtualString >> HeapHandleType.OffsetBitCount),

        WinRTPrefixed = (byte)(StringHandleType.WinRTPrefixedString >> HeapHandleType.OffsetBitCount),

        DotTerminated = (byte)(StringHandleType.DotTerminatedString >> HeapHandleType.OffsetBitCount),
    }
}
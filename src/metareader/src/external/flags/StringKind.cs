//-----------------------------------------------------------------------------
// Copyright   :  Microsoft
// License     : MIT via .Net Foundation
// Extracted from System.Reflection.MetadataReader library code
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;

    partial class MetadataFlags
    {
        internal enum StringKind : byte
        {
            Plain = (byte)(StringHandleType.String >> HeapHandleType.OffsetBitCount),
            Virtual = (byte)(StringHandleType.VirtualString >> HeapHandleType.OffsetBitCount),
            WinRTPrefixed = (byte)(StringHandleType.WinRTPrefixedString >> HeapHandleType.OffsetBitCount),
            DotTerminated = (byte)(StringHandleType.DotTerminatedString >> HeapHandleType.OffsetBitCount),
        }        
    }
}
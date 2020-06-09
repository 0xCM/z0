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
        internal static class StringHandleType
        {
            // The 3 high bits above the offset that specify the full string type (including virtual bit)
            internal const uint TypeMask = ~(HeapHandleType.OffsetMask);

            // The string type bits excluding the virtual bit.
            internal const uint NonVirtualTypeMask = TypeMask & ~(HeapHandleType.VirtualBit);

            // NUL-terminated UTF8 string on a #String heap.
            internal const uint String = (0 << HeapHandleType.OffsetBitCount);

            // String on #String heap whose terminator is NUL and '.', whichever comes first.
            internal const uint DotTerminatedString = (1 << HeapHandleType.OffsetBitCount);

            // Reserved values that can be used for future strings:
            internal const uint ReservedString1 = (2 << HeapHandleType.OffsetBitCount);
            internal const uint ReservedString2 = (3 << HeapHandleType.OffsetBitCount);

            // Virtual string identified by a virtual index
            internal const uint VirtualString = HeapHandleType.VirtualBit | (0 << HeapHandleType.OffsetBitCount);

            // Virtual string whose value is a "<WinRT>" prefixed string found at the specified heap offset.
            internal const uint WinRTPrefixedString = HeapHandleType.VirtualBit | (1 << HeapHandleType.OffsetBitCount);

            // Reserved virtual strings that can be used in future:
            internal const uint ReservedVirtualString1 = HeapHandleType.VirtualBit | (2 << HeapHandleType.OffsetBitCount);
            internal const uint ReservedVirtualString2 = HeapHandleType.VirtualBit | (3 << HeapHandleType.OffsetBitCount);
        }        
    }
}
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
        internal static class HeapHandleType
        {
            // Heap offset values are limited to 29 bits (max compressed integer)
            internal const int OffsetBitCount = 29;
            internal const uint OffsetMask = (1 << OffsetBitCount) - 1;
            internal const uint VirtualBit = 0x80000000;

            internal static bool IsValidHeapOffset(uint offset)
            {
                return (offset & ~OffsetMask) == 0;
            }
        }       
    }

}
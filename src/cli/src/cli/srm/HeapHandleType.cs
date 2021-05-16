// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Z0
{
    public readonly partial struct SrmInternals
    {
        readonly struct HeapHandleType
        {
            // Heap offset values are limited to 29 bits (max compressed integer)
            public const byte OffsetBitCount = 29;

            public const uint OffsetMask = (1 << OffsetBitCount) - 1;

            public const uint VirtualBit = 0x80000000;

            public static bool IsValidHeapOffset(uint offset)
                => (offset & ~OffsetMask) == 0;

        }


    }
}
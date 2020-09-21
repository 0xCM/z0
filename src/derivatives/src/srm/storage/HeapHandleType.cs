//-----------------------------------------------------------------------------
// Derivative Work
// Origin:    : https://github.com/microsoft/scalar
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Derivatives.SRM
{
    public static class HeapHandleType
    {
        // Heap offset values are limited to 29 bits (max compressed integer)
        public const int OffsetBitCount = 29;

        public const uint OffsetMask = (1 << OffsetBitCount) - 1;

        public const uint VirtualBit = 0x80000000;

        public static bool IsValidHeapOffset(uint offset)
            => (offset & ~OffsetMask) == 0;
    }
}
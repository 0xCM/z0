//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class BitMasks
    {
        partial struct Literals
        {
            [BitMask("[00000001 00000001 00000001 00000001]")]
            public const uint b00000001x32 = (uint)b00000001x16 << 16 | (uint)b00000001x16;

            [BitMask("[00000010 00000010 00000010 00000010]")]
            public const uint b00000010x32 = (uint)b00000010x16 << 16 | (uint)b00000010x16;

            [BitMask("[00000100 00000100 00000100 00000100]")]
            public const uint b00000100x32 = (uint)b00000100x16 << 16 | (uint)b00000100x16;

            public const uint b00001000x32 = (uint)b00001000x16 << 16 | (uint)b00001000x16;

            public const uint b00010000x32 = (uint)b00010000x16 << 16 | (uint)b00010000x16;

            public const uint b00100000x32 = (uint)b00100000x16 << 16 | (uint)b00100000x16;

            public const uint b01000000x32 = (uint)b01000000x16 << 16 | (uint)b01000000x16;

            public const uint b10000000x32 = (uint)b10000000x16 << 16 | (uint)b10000000x16;

            public const uint b01010101x32 = 0x55555555;

            public const uint b00110011x32 = 0x33333333;

            public const uint b00001111x32 = 0x0f0f0f0f;

        }
    }
}
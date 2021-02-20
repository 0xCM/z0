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
            [BitMask("[00000001 00000001]")]
            public const ushort b00000001x16 = (ushort)b00000001x8 << 8 | (ushort)b00000001x8;

            [BitMask("[00000010 00000010]")]
            public const ushort b00000010x16 = (ushort)b00000010x8 << 8 | (ushort)b00000010x8;

            [BitMask("[00000100 00000100]")]
            public const ushort b00000100x16 = (ushort)b00000100x8 << 8 | (ushort)b00000100x8;

            [BitMask("[00001000 00001000]")]
            public const ushort b00001000x16 = (ushort)b00001000x8 << 8 | (ushort)b00001000x8;

            [BitMask("[00010000 00010000]")]
            public const ushort b00010000x16 = (ushort)b00010000x8 << 8 | (ushort)b00010000x8;

            [BitMask("[00100000 00100000]")]
            public const ushort b00100000x16 = (ushort)b00100000x8 << 8 | (ushort)b00100000x8;

            [BitMask("[01000000 01000000]")]
            public const ushort b01000000x16 = (ushort)b01000000x8 << 8 | (ushort)b01000000x8;

            [BitMask("[10000000 10000000]")]
            public const ushort b10000000x16 = (ushort)b10000000x8 << 8 | (ushort)b10000000x8;

            [BitMask("[01010101 01010101]")]
            public const ushort b01010101x16 = 0x5555;

            [BitMask("[00110011 00110011]")]
            public const ushort b00110011x16 = 0x3333;

            [BitMask("[00001111 00001111]")]
            public const ushort b00001111x16 = 0x0f0f;
        }
    }
}
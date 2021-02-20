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
            [BitMask("[00000001 00000001 00000001 00000001 00000001 00000001 00000001 00000001]")]
            public const ulong b00000001x64 = (ulong)b00000001x32 << 32 | (ulong)b00000001x32;

            [BitMask("[00000010 00000010 00000010 00000010 00000010 00000010 00000010 00000010]")]
            public const ulong b00000010x64 = (ulong)b00000010x32 << 32 | (ulong)b00000010x32;

            public const ulong b00000100x64 = (ulong)b00000100x32 << 32 | (ulong)b00000100x32;

            public const ulong b00001000x64 = (ulong)b00001000x32 << 32 | (ulong)b00001000x32;

            public const ulong b00010000x64 = (ulong)b00010000x32 << 32 | (ulong)b00010000x32;

            public const ulong b00100000x64 = (ulong)b00100000x32 << 32 | (ulong)b00100000x32;

            public const ulong b01000000x64 = (ulong)b01000000x32 << 32 | (ulong)b01000000x32;

            public const ulong b10000000x64 = (ulong)b10000000x32 << 32 | (ulong)b10000000x32;

            public const ulong b01010101x64 = 0x5555555555555555;

            public const ulong b00110011x64 = 0x3333333333333333;

            public const ulong b00001111x64 = 0x0f0f0f0f0f0f0f0f;
        }
    }
}
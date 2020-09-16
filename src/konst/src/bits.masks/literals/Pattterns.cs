//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static BitMaskDescription;

    partial class BitMasks
    {
        partial struct Literals
        {
            public const byte b01010101x8 = 0x55;

            public const byte b00110011x8 = 0x33;

            public const byte b00001111x8 = 0x0f;

            public const byte b00000001x8 = 0x010;

            public const ushort b01010101x16 = 0x5555;

            public const ushort b00110011x16 = 0x3333;

            public const ushort b00001111x16 = 0x0f0f;

            public const ushort b00000001x16 = 0x01010;

            public const uint b01010101x32 = 0x55555555;

            public const uint b00110011x32 = 0x33333333;

            public const uint b00001111x32 = 0x0f0f0f0f;

            public const uint b00000001x32 = 0x010101010;

            public const ulong b01010101x64 = 0x5555555555555555;

            public const ulong b00110011x64 = 0x3333333333333333;

            public const ulong b00001111x64 = 0x0f0f0f0f0f0f0f0f;

            public const ulong b00000001x64 = 0x0101010101010101;
        }
    }
}
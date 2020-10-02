//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static BitMasks.Bp8;

    partial class BitMasks
    {
        /// <summary>
        /// Defines a bit pattern set with members of bit-width <see cref='W16'/>
        /// </summary>
        [LiteralProvider]
        public readonly struct Bp16
        {
            public const ushort b00000001x16 = (ushort)b00000001x8 << 8 | (ushort)b00000001x8;

            public const ushort b00000010x16 = (ushort)b00000010x8 << 8 | (ushort)b00000010x8;

            public const ushort b00000100x16 = (ushort)b00000100x8 << 8 | (ushort)b00000100x8;

            public const ushort b00001000x16 = (ushort)b00001000x8 << 8 | (ushort)b00001000x8;

            public const ushort b00010000x16 = (ushort)b00010000x8 << 8 | (ushort)b00010000x8;

            public const ushort b00100000x16 = (ushort)b00100000x8 << 8 | (ushort)b00100000x8;

            public const ushort b01000000x16 = (ushort)b01000000x8 << 8 | (ushort)b01000000x8;

            public const ushort b10000000x16 = (ushort)b10000000x8 << 8 | (ushort)b10000000x8;

            public const ushort b01010101x16 = 0x5555;

            public const ushort b00110011x16 = 0x3333;

            public const ushort b00001111x16 = 0x0f0f;

        }
    }
}
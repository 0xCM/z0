//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
 
    using static zfunc;

    partial class BitMasks
    {            

        /// <summary>
        /// [01010101]
        /// </summary>
        public const byte Even8 = Lsb8x2x1;

        /// <summary>
        /// [01010101 01010101]
        /// </summary>
        public const ushort Even16 = (ushort)Even8 | (ushort)Even8 << 8;

        /// <summary>
        /// [01010101 01010101 01010101 01010101]
        /// </summary>
        public const uint Even32 = (ushort)Even16 | (ushort)Even16 << 16;

        /// <summary>
        /// [01010101 01010101 01010101 01010101 01010101 01010101 01010101 01010101]
        /// </summary>
        public const ulong Even64 = (ulong)Even32 | (ulong)Even32 << 32;

        /// <summary>
        /// [00110011]
        /// </summary>
        public const byte Even8x2 = 0b00110011;

        /// <summary>
        /// [00110011 00110011]
        /// </summary>
        public const ushort Even16x2 = (ushort)Even8x2 | (ushort)Even8x2 << 8;

        /// <summary>
        /// [00110011 00110011 00110011 00110011]
        /// </summary>
        public const uint Even32x2 = (uint)Even16x2 | (uint)Even16x2 << 16;

        /// <summary>
        /// [00110011 00110011 00110011 00110011 00110011 00110011 00110011 00110011]
        /// </summary>
        public const ulong Even64x2 = (ulong)Even32x2 | (ulong)Even32x2 << 32;

        // ~ Odd [10101010]
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// [10101010]
        /// </summary>
        public const byte Odd8 = Msb8x2x1;

        /// <summary>
        /// [10101010 10101010]
        /// </summary>
        public const ushort Odd16 = (ushort)Odd8 | (ushort)Odd8 << 8;

        /// <summary>
        /// [10101010 10101010 10101010 10101010]
        /// </summary>
        public const uint Odd32 = (uint)Odd16 | (uint)Odd16 << 16;

        /// <summary>
        /// [10101010 10101010 10101010 10101010 10101010 10101010 10101010 10101010]
        /// </summary>
        public const ulong Odd64 = (ulong)Odd32 | (ulong)Odd32 << 32;

        // ~ Odd8x2 [11001100]
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// [11001100]
        /// </summary>
        public const byte Odd8x2 = 0b11001100;

        /// <summary>
        /// [11001100 11001100]
        /// </summary>
        public const ushort Odd16x2 = (ushort)Odd8x2 | (ushort)Odd8x2 << 8;

        /// <summary>
        /// [11001100 11001100 11001100 11001100]
        /// </summary>
        public const uint Odd32x2 = (uint)Odd16x2 | (uint)Odd16x2 << 16;

        /// <summary>
        /// [11001100 11001100 11001100 11001100 11001100 11001100 11001100 11001100]
        /// </summary>
        public const ulong Odd64x2 = (ulong)Odd32x2 | (ulong)Odd32x2 << 32;

        // ~ Jsb8x1 [10000001]
        // ~ ------------------------------------------------------------------


    }

}
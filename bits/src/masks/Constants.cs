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
        public const byte Even8 = 0b01010101;

        public const ushort Even16 = (ushort)Even8 | (ushort)Even8 << 8;

        public const uint Even32 = (ushort)Even16 | (ushort)Even16 << 16;

        public const ulong Even64 = (ulong)Even32 | (ulong)Even32 << 32;

        public const byte Odd8 = 0b10101010;

        public const ushort Odd16 = (ushort)Odd8 | (ushort)Odd8 << 8;

        public const uint Odd32 = (uint)Odd16 | (uint)Odd16 << 16;

        public const ulong Odd64 = (ulong)Odd32 | (ulong)Odd32 << 32;
    
        /// <summary>
        /// [00000001]
        /// </summary>
        public const byte Lsb8 = 1;

        /// <summary>
        /// [00000000 00000001]
        /// </summary>
        public const ushort Lsb16 = 1;

        /// <summary>
        /// [00000000 00000000 00000000 0000001]
        /// </summary>
        public const uint Lsb32 = 1;

        /// <summary>
        /// [00000000 00000000 00000000 0000000 00000000 00000000 00000000 0000001]
        /// </summary>
        public const uint Lsb64 = 1;

        /// <summary>
        /// [01010101]
        /// </summary>
        public const byte Lsb8x2 = 0b01010101;

        /// <summary>
        /// [00010001]
        /// </summary>
        public const byte Lsb8x4 = 0b00010001;

        /// <summary>
        /// [01010101 01010101]
        /// </summary>
        public const ushort Lsb16x2 = (ushort)Lsb8x2 | (ushort)Lsb8x2 << 8;

        /// <summary>
        /// [00010001 00010001]
        /// </summary>
        public const ushort Lsb16x4 = (ushort)Lsb8x4  | (ushort)Lsb8x4 << 8;

        /// <summary>
        /// [00000001 00000001]
        /// </summary>
        public const ushort Lsb16x8 = (ushort)Lsb8 | (ushort) Lsb8 << 8;

        /// <summary>
        /// [01010101 01010101 01010101 01010101]
        /// </summary>
        public const uint Lsb32x2 = (uint)Lsb16x2 | (uint)Lsb16x2 << 16;

        /// <summary>
        /// [00010001 00010001 00010001 00010001]
        /// </summary>
        public const uint Lsb32x4 = (uint)Lsb16x4 | (uint)Lsb16x4 << 16;

        /// <summary>
        /// [00000001 00000001 00000001 00000001]
        /// </summary>
        public const uint Lsb32x8 = (uint) Lsb16x8 | (uint) Lsb16x8 << 16;

        /// <summary>
        /// [00000000 00000001 00000000 00000001]
        /// </summary>
        public const uint Lsb32x16 = (uint)Lsb16 | (uint)Lsb16 << 16;

        /// <summary>
        /// [01010101 01010101 01010101 01010101 01010101 01010101 01010101 01010101]
        /// </summary>
        public const ulong Lsb64x2 = (ulong)Lsb32x2 | (ulong)Lsb32x2 << 32;

        /// <summary>
        /// [00010001 00010001 00010001 00010001 00010001 00010001 00010001 00010001]
        /// </summary>
        public const ulong Lsb64x4 = (ulong)Lsb32x4 | (ulong)Lsb32x4 << 32;

        /// <summary>
        /// [00000001 00000001 00000001 00000001 00000001 00000001 00000001 00000001]
        /// </summary>
        public const ulong Lsb64x8 = (ulong)Lsb32x8 | (ulong)Lsb32x8 << 32;

        /// <summary>
        /// [00000000 00000001 00000000 00000001 00000000 00000001 00000000 00000001]
        /// </summary>
        public const ulong Lsb64x16 = (ulong)Lsb32x16 | (ulong)Lsb32x16 << 32;

        /// <summary>
        /// [00000000 00000000 00000000 0000001 00000000 00000000 00000000 0000001]
        /// </summary>
        public const ulong Lsb64x32 = (ulong)Lsb32 | (ulong) Lsb32 << 32;

        /// <summary>
        /// [00000011]
        /// </summary>
        public const byte Lsb8x8x2 = 0b00000011;

        /// <summary>
        /// [00000111]
        /// </summary>
        public const byte Lsb8x8x3 = 0b00000111;

        /// <summary>
        /// [00001111]
        /// </summary>
        public const byte Lsb8x8x4 = 0b00001111;

        /// <summary>
        /// [00011111]
        /// </summary>
        public const byte Lsb8x8x5 = 0b00011111;

        /// <summary>
        /// [00111111]
        /// </summary>
        public const byte Lsb8x8x6 = 0b00111111;

        /// <summary>
        /// [01111111]
        /// </summary>
        public const byte Lsb8x8x7 = 0b01111111;

        /// <summary>
        /// [00000011 00000011]
        /// </summary>
        public const ushort Lsb16x8x2 = (ushort) Lsb8x8x2 | (ushort)Lsb8x8x2 << 8;

        /// <summary>
        /// [00000111 00000111]
        /// </summary>
        public const ushort Lsb16x8x3 = (ushort) Lsb8x8x3 | (ushort)Lsb8x8x3 << 8;

        /// <summary>
        /// [00001111 00001111]
        /// </summary>
        public const ushort Lsb16x8x4 = (ushort)Lsb8x8x4 | (ushort)Lsb8x8x4 << 8;

        /// <summary>
        /// [00011111 00011111]
        /// </summary>
        public const ushort Lsb16x8x5 = (ushort)Lsb8x8x5 | (ushort)Lsb8x8x5 << 8;

        /// <summary>
        /// [00111111 00111111]
        /// </summary>
        public const ushort Lsb16x8x6 = (ushort)Lsb8x8x6 | (ushort)Lsb8x8x6 << 8;

        /// <summary>
        /// [01111111 01111111]
        /// </summary>
        public const ushort Lsb16x8x7 = (ushort)Lsb8x8x7 | (ushort)Lsb8x8x7 << 8;

        /// <summary>
        /// [00000111 00000111 00000111 00000111]
        /// </summary>
        public const uint Lsb32x8x2 = (uint)Lsb16x8x2 | (uint)Lsb16x8x2 << 16;

        /// <summary>
        /// [00000111 00000111 00000111 00000111]
        /// </summary>
        public const uint Lsb32x8x3 = (uint)Lsb16x8x3 | (uint)Lsb16x8x3 << 16;

        /// <summary>
        /// [00001111 00001111 00001111 00001111]
        /// </summary>
        public const uint Lsb32x8x4 = (uint)Lsb16x8x4 | (uint)Lsb16x8x4 << 16;

        /// <summary>
        /// [00011111 00011111 00011111 00011111]
        /// </summary>
        public const uint Lsb32x8x5 = (uint)Lsb16x8x5 | (uint)Lsb16x8x5 << 16;

        /// <summary>
        /// [00111111 00111111 00111111 00111111]
        /// </summary>
        public const uint Lsb32x8x6 = (uint)Lsb16x8x6 | (uint)Lsb16x8x6 << 16;

        /// <summary>
        /// [01111111 01111111 01111111 01111111]
        /// </summary>
        public const uint Lsb32x8x7 = (uint)Lsb16x8x7 | (uint)Lsb16x8x7 << 16;

        /// <summary>
        /// [00000011 00000011 00000011 00000011 00000011 00000011 00000011 00000011]
        /// </summary>
        public const ulong Lsb64x8x2 = (ulong)Lsb32x8x2 | (ulong)Lsb32x8x2 << 32;

        /// <summary>
        /// [00000111 00000111 00000111 00000111 00000111 00000111 00000111 00000111]
        /// </summary>
        public const ulong Lsb64x8x3 = (ulong)Lsb32x8x3 | (ulong)Lsb32x8x3 << 32;

        /// <summary>
        /// [00001111 00001111 00001111 00001111 00001111 000011110 0001111 00001111]
        /// </summary>
        public const ulong Lsb64x8x4 = (ulong)Lsb32x8x4 | (ulong)Lsb32x8x4 << 32;

        /// <summary>
        /// [00011111 00011111 00011111 00011111 00011111 00011111 00011111 00011111]
        /// </summary>
        public const ulong Lsb64x8x5 = (ulong)Lsb32x8x5 | (ulong)Lsb32x8x5 << 32;

        /// <summary>
        /// [00111111 00111111 00111111 00111111 00111111 00111111 00111111 00111111]
        /// </summary>
        public const ulong Lsb64x8x6 = (ulong)Lsb32x8x6 | (ulong)Lsb32x8x6 << 32;

        /// <summary>
        /// [01111111 01111111 01111111 01111111 01111111 01111111 01111111 01111111]
        /// </summary>
        public const ulong Lsb64x8x7 = (ulong)Lsb32x8x7 | (ulong)Lsb32x8x7 << 32;

        // ~ MSB
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// [10000000]
        /// </summary>
        public const byte Msb8 = 1 << 7;

        /// <summary>
        /// [10000000 00000000]
        /// </summary>
        public const ushort Msb16 = 1 << 15;

        /// <summary>
        /// [10000000 00000000 00000000 0000000]
        /// </summary>
        public const uint Msb32 = 1u << 31;

        /// <summary>
        /// [10000000 00000000 00000000 0000000 00000000 00000000 00000000 0000000]
        /// </summary>
        public const ulong Msb64 = 1ul << 63;

        /// <summary>
        /// [10101010]
        /// </summary>
        public const byte Msb8x2 = Lsb8x2 << 1;

        /// <summary>
        /// [10000000 10000000]
        /// </summary>
        public const ushort Msb16x8 = (ushort)Msb8 | (ushort)Msb8 << 8 ; 

        /// <summary>
        /// [10000000 10000000 10000000 10000000]
        /// </summary>
        public const uint Msb32x8 = (uint)Msb16x8 | (uint)Msb16x8 << 16;

        /// <summary>
        /// [10101010_10101010_10101010_10101010_10101010_10101010_10101010_10101010]
        /// </summary>
        public const ulong Msb64x2 = Lsb64x2 << 1;

        /// <summary>
        /// [10000000 10000000 10000000 10000000 10000000 10000000 10000000 10000000]
        /// </summary>
        public const ulong Msb64x8 = (ulong)Msb32x8 | (ulong)Msb32x8 << 32;

        /// <summary>
        /// [10000000 00000000 00000000 0000000 10000000 00000000 00000000 0000000]
        /// </summary>
        public const ulong Msb64x32 =(ulong)Msb32 | (ulong)Msb32 << 32;

        /// <summary>
        /// [11000000]
        /// </summary>
        public const byte Msb8x8x2 = 0b11000000;

        /// <summary>
        /// [11100000]
        /// </summary>
        public const byte Msb8x8x3 = 0b11100000;

        /// <summary>
        /// [11110000]
        /// </summary>
        public const byte Msb8x8x4 = 0b11110000;

        /// <summary>
        /// [11111000]
        /// </summary>
        public const byte Msb8x8x5 = 0b11111000;

        /// <summary>
        /// [11111100]
        /// </summary>
        public const byte Msb8x8x6 = 0b11111100;

        /// <summary>
        /// [11111100]
        /// </summary>
        public const byte Msb8x8x7 = 0b11111110;

        /// <summary>
        /// [11000000 11000000]
        /// </summary>
        public const ushort Msb16x8x2 = (ushort)Msb8x8x2 | (ushort)Msb8x8x2 << 8;

        /// <summary>
        /// [11100000 11100000]
        /// </summary>
        public const ushort Msb16x8x3 = (ushort)Msb8x8x3 | (ushort)Msb8x8x3 << 8;

        /// <summary>
        /// [11110000 11110000]
        /// </summary>
        public const ushort Msb16x8x4 = (ushort)Msb8x8x4 | (ushort)Msb8x8x4 << 8;

        /// <summary>
        /// [11111000 11111000]
        /// </summary>
        public const ushort Msb16x8x5 = (ushort)Msb8x8x5 | (ushort)Msb8x8x5 << 8;

        /// <summary>
        /// [11111100 11111100]
        /// </summary>
        public const ushort Msb16x8x6 = (ushort)Msb8x8x6 | (ushort)Msb8x8x6 << 8;

        /// <summary>
        /// [11111110 11111110]
        /// </summary>
        public const ushort Msb16x8x7 = (ushort)Msb8x8x7 | (ushort)Msb8x8x7 << 8;

        /// <summary>
        /// [11000000 11000000 11000000 11000000]
        /// </summary>
        public const uint Msb32x8x2 = (uint)Msb16x8x2 | (uint)Msb16x8x2 << 16;

        /// <summary>
        /// [11100000 11100000 11100000 11100000]
        /// </summary>
        public const uint Msb32x8x3 = (uint)Msb16x8x3 | (uint)Msb16x8x3 << 16;

        /// <summary>
        /// [11110000 11110000 11110000 11110000]
        /// </summary>
        public const uint Msb32x8x4 = (uint)Msb16x8x4 | (uint)Msb16x8x4 << 16;

        /// <summary>
        /// [11111000 11111000 11111000 11111000]
        /// </summary>
        public const uint Msb32x8x5 = (uint)Msb16x8x5 | (uint)Msb16x8x5 << 16;

        /// <summary>
        /// [11111100 11111100 11111100 11111100]
        /// </summary>
        public const uint Msb32x8x6 = (uint)Msb16x8x6 | (uint)Msb16x8x6 << 16;

        /// <summary>
        /// [11111110 11111110 11111110 11111110]
        /// </summary>
        public const uint Msb32x8x7 = (uint)Msb16x8x7 | (uint)Msb16x8x7 << 16;

        /// <summary>
        /// [11000000 11000000 11000000 11000000 11000000 11000000 11000000 11000000]
        /// </summary>
        public const ulong Msb64x8x2 = (ulong)Msb32x8x2 | (ulong)Msb32x8x2 << 32;

        /// <summary>
        /// [11100000 11100000 11100000 11100000 11100000 11100000 11100000 11100000]
        /// </summary>
        public const ulong Msb64x8x3 = (ulong)Msb32x8x3 | (ulong)Msb32x8x3 << 32;

        /// <summary>
        /// [11110000 11110000 11110000 11110000 11110000 11110000 11110000 11110000]
        /// </summary>
        public const ulong Msb64x8x4 = (ulong)Msb32x8x4 | (ulong)Msb32x8x4 << 32;

        /// <summary>
        /// [11111000 11111000 11111000 11111000 11111000 11111000 11111000 11111000]
        /// </summary>
        public const ulong Msb64x8x5 = (ulong)Msb32x8x5 | (ulong)Msb32x8x5 << 32;

        /// <summary>
        /// [11111100 11111100 11111100 11111100 11111100 11111100 11111100 11111100]
        /// </summary>
        public const ulong Msb64x8x6 = (ulong)Msb32x8x6 | (ulong)Msb32x8x6 << 32;

        /// <summary>
        /// [11111110 11111110 11111110 11111110 11111110 11111110 11111110 11111110]
        /// </summary>
        public const ulong Msb64x8x7 = (ulong)Msb32x8x7 | (ulong)Msb32x8x7 << 32;


    }


}
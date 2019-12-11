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

    public static partial class BitMasks
    {            
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
        public const ulong Lsb64 = 1;

        /// <summary>
        /// [01 01]
        /// </summary>
        public const byte Lsb4x2 = 0b0101;

        /// <summary>
        /// [01 01 01]
        /// </summary>
        public const byte Lsb6x2 = Lsb4x2 | 1 << 4;

        /// <summary>
        /// [001 001]
        /// </summary>
        public const byte Lsb6x3 = 1 | 1 << 3;

        /// <summary>
        /// [01 01 01 01]
        /// </summary>
        public const byte Lsb8x2 = Lsb6x2 | 1 << 6;

        /// <summary>
        /// [00010001]
        /// </summary>
        public const byte Lsb8x4 = 1 | 1 << 4;

        /// <summary>
        /// [00000011]
        /// </summary>
        public const byte Lsb8x8x2 = 1 | 1 << 1;
        
        /// <summary>
        /// [00000111]
        /// </summary>
        public const byte Lsb8x8x3 = Lsb8x8x2 << 1 | 1;

        /// <summary>
        /// [00001111]
        /// </summary>
        public const byte Lsb8x8x4 = Lsb8x8x3 << 1 | 1;

        /// <summary>
        /// [00011111]
        /// </summary>
        public const byte Lsb8x8x5 = Lsb8x8x4 << 1 | 1;

        /// <summary>
        /// [00111111]
        /// </summary>
        public const byte Lsb8x8x6 = Lsb8x8x5 << 1 | 1;

        /// <summary>
        /// [01111111]
        /// </summary>
        public const byte Lsb8x8x7 = Lsb8x8x6 << 1 | 1;

        /// <summary>
        /// [01 01 01 01 01]
        /// </summary>
        public const ushort Lsb10x2 = (ushort)Lsb8x2 | 1 << 8;

        /// <summary>
        /// [00001 00001]
        /// </summary>
        public const ushort Lsb10x5 = 1 | 1 << 5;
        
        /// <summary>
        /// [01 01 01 01 01 01]
        /// </summary>
        public const ushort Lsb12x2 = Lsb10x2 | 1 << 10;

        /// <summary>
        /// [001 001 001 001]
        /// </summary>
        public const ushort Lsb12x3 = Lsb6x3 | Lsb6x3 << 6;

        /// <summary>
        /// [0001 0001 0001]
        /// </summary>
        public const ushort Lsb12x4 = (ushort)Lsb8x4 | 1 << 8;

        /// <summary>
        /// [000001 000001]
        /// </summary>
        public const ushort Lsb12x6 = 1 | 1 << 6;

        /// <summary>
        /// [01 01 01 01 01 01 01]
        /// </summary>
        public const ushort Lsb14x2 = Lsb12x2 | 1 << 12;

        /// <summary>
        /// [0000001 0000001]
        /// </summary>
        public const ushort Lsb14x7 = 1 | 1 << 7;

        /// <summary>
        /// [001 001 001 001 001]
        /// </summary>
        public const ushort Lsb15x3 = Lsb12x3 | 1 << 12;

        /// <summary>
        /// [01 01 01 01 01 01 01 01]
        /// </summary>
        public const ushort Lsb16x2 = (ushort)Lsb8x2 | (ushort)Lsb8x2 << 8;

        /// <summary>
        /// [0001 0001 0001 0001]
        /// </summary>
        public const ushort Lsb16x4 = (ushort)Lsb8x4  | (ushort)Lsb8x4 << 8;

        /// <summary>
        /// [00000001 00000001]
        /// </summary>
        public const ushort Lsb16x8 = 1 | 1 << 8;

        /// <summary>
        /// [01 01 01 01 01 01 01 01 01]
        /// </summary>
        public const uint Lsb18x2 = (uint)Lsb16x2 | 1u << 16;

        /// <summary>
        /// [001 001 001 001 001 001]
        /// </summary>
        public const uint Lsb18x3 = (uint)Lsb15x3 | 1u << 15;

        /// <summary>
        /// [000001 000001 000001]
        /// </summary>
        public const uint Lsb18x6 = (uint)Lsb12x6 | 1u << 12;        

        /// <summary>
        /// [001 001 001 001 001 001 001 001]
        /// </summary>        
        public const uint Lsb24x3 = (uint)Lsb12x3 | (uint)Lsb12x3 << 16;

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
        public const uint Lsb32x8 = (uint)Lsb16x8 | (uint) Lsb16x8 << 16;

        /// <summary>
        /// [00000000 00000001 00000000 00000001]
        /// </summary>
        public const uint Lsb32x16 = 1u | 1u << 16;

        /// <summary>
        /// [001 001 001 001 001 001 001 001 001 001 001 001 001 001 001 001]
        /// </summary>        
        public const ulong Lsb48x3 = (ulong)Lsb24x3 | (ulong)Lsb24x3 << 32;

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
        public const ulong Lsb64x32 = 1ul | 1ul << 32;

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
        /// [00000011 00000011 00000011 00000011]
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
        /// [10101010]
        /// </summary>
        public const byte Msb8x2 = Lsb8x2 << 1;

        /// <summary>
        /// [10001000]
        /// </summary>
        public const byte Msb8x4 = 0b10001000;


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
        /// [10101010 10101010]
        /// </summary>
        public const ushort Msb16x2 = (ushort)Msb8x2 | (ushort)Msb8x2 << 8;

        /// <summary>
        /// [10001000 10001000]
        /// </summary>
        public const ushort Msb16x4 = (ushort)Msb8x4  | (ushort)Msb8x4 << 8;

        /// <summary>
        /// [10000000 10000000]
        /// </summary>
        public const ushort Msb16x8 = (ushort)Msb8 | (ushort)Msb8 << 8 ; 

        /// <summary>
        /// [10101010 10101010 10101010 10101010]
        /// </summary>
        public const uint Msb32x2 = (uint)Msb16x2 | (uint)Msb16x2 << 16;

        /// <summary>
        /// [10001000 10001000 10001000 10001000]
        /// </summary>
        public const uint Msb32x4 = (uint)Msb16x4 | (uint)Msb16x4 << 16;

        /// <summary>
        /// [10000000 10000000 10000000 10000000]
        /// </summary>
        public const uint Msb32x8 = (uint)Msb16x8 | (uint)Msb16x8 << 16;

        /// <summary>
        /// [10000000 00000000 10000000 00000000]
        /// </summary>
        public const uint Msb32x16 = (uint)Msb16 | (uint)Msb16 << 16;

        /// <summary>
        /// [10101010_10101010_10101010_10101010_10101010_10101010_10101010_10101010]
        /// </summary>
        public const ulong Msb64x2 = Lsb64x2 << 1;

        /// <summary>
        /// [10001000 10001000 10001000 10001000 10001000 10001000 10001000 10001000]
        /// </summary>
        public const ulong Msb64x4 = (ulong)Msb32x4 | (ulong)Msb32x4 << 16;

        /// <summary>
        /// [10000000 10000000 10000000 10000000 10000000 10000000 10000000 10000000]
        /// </summary>
        public const ulong Msb64x8 = (ulong)Msb32x8 | (ulong)Msb32x8 << 32;

        /// <summary>
        /// [10000000 00000000 10000000 00000000 10000000 00000000 10000000 00000000]
        /// </summary>
        public const ulong Msb64x16 = (ulong)Msb32x16 | (ulong)Msb32x16 << 16;

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

        /// <summary>
        /// [01010101]
        /// </summary>
        public const byte Even8 = Lsb8x2;

        public const ushort Even16 = (ushort)Even8 | (ushort)Even8 << 8;

        public const uint Even32 = (ushort)Even16 | (ushort)Even16 << 16;

        public const ulong Even64 = (ulong)Even32 | (ulong)Even32 << 32;

        /// <summary>
        /// [10101010]
        /// </summary>
        public const byte Odd8 = Msb8x2;

        public const ushort Odd16 = (ushort)Odd8 | (ushort)Odd8 << 8;

        public const uint Odd32 = (uint)Odd16 | (uint)Odd16 << 16;

        public const ulong Odd64 = (ulong)Odd32 | (ulong)Odd32 << 32;

        /// <summary>
        /// [00011000]
        /// </summary>
        public const byte Central8x2 = 0b00011000;

        /// <summary>
        /// [00111100]
        /// </summary>
        public const byte Central8x4 = 0b00111100;

        /// <summary>
        /// [01111110]
        /// </summary>
        public const byte Central8x6 = 0b01111110;

        /// <summary>
        /// [00000001 10000000]
        /// </summary>
        public const ushort Central16x2 = (ushort) Msb8 | (ushort)Lsb8 << 8;

        /// <summary>
        /// [00000011 11000000]
        /// </summary>
        public const ushort Central16x4 = (ushort) Msb8x8x2 | (ushort)Lsb8x8x2 << 8; 

        /// <summary>
        /// [00000111 11100000]
        /// </summary>
        public const ushort Central16x6 = (ushort) Msb8x8x3 | (ushort)Lsb8x8x3 << 8; 

        /// <summary>
        /// [00001111 11110000]
        /// </summary>
        public const ushort Central16x8 = (ushort) Msb8x8x4 | (ushort)Lsb8x8x4 << 8; 

        /// <summary>
        /// [00011111 11111000]
        /// </summary>
        public const ushort Central16x10 = (ushort) Msb8x8x5 | (ushort)Lsb8x8x5 << 8; 

        /// <summary>
        /// [00111111 11111100]
        /// </summary>
        public const ushort Central16x12 = (ushort) Msb8x8x6 | (ushort)Lsb8x8x6 << 8; 

        /// <summary>
        /// [01111111 11111110]
        /// </summary>
        public const ushort Central16x14 = (ushort) Msb8x8x7 | (ushort)Lsb8x8x7 << 8; 

        /// <summary>
        /// [00011000 00011000]
        /// </summary>
        public const ushort Central16x8x2 = (ushort)Central8x2 | (ushort)Central8x2 << 8;

        /// <summary>
        /// [00111100 00111100]
        /// </summary>
        public const ushort Central16x8x4 = (ushort)Central8x4 | (ushort)Central8x4 << 8;

        /// <summary>
        /// [01111110 01111110]
        /// </summary>
        public const ushort Central16x8x6 = (ushort)Central8x6 | (ushort)Central8x6 << 8;

        /// <summary>
        /// [00011000 00011000 00011000 00011000]
        /// </summary>
        public const uint Central32x8x2 = (uint)Central16x8x2 | (uint)Central16x8x2 << 8;

        /// <summary>
        /// [00111100 00111100 00111100 00111100]
        /// </summary>
        public const uint Central32x8x4 = (uint)Central16x8x4 | (uint)Central16x8x4 << 8;

        /// <summary>
        /// [00000000 00000001 10000000 00000000]
        /// </summary>
        public const uint Central32x2 = (uint) Msb16 | (uint)Lsb16 << 8;

        /// <summary>
        /// [00011000 00011000 00011000 00011000 00011000 00011000 00011000 00011000]
        /// </summary>
        public const ulong Central64x8x2 = (ulong)Central32x8x2 | (ulong)Central32x8x2 << 8;

        /// <summary>
        /// [00111100 00111100 00111100 00111100 00111100 00111100 00111100 00111100]
        /// </summary>
        public const ulong Central64x8x4 = (ulong)Central32x8x4 | (ulong)Central32x8x4 << 8;

    }


}
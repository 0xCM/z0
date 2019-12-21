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
        /// [00000001 00000001]
        /// </summary>
        public const ushort Lsb16x8 = 1 | 1 << 8;

        /// <summary>
        /// [00000001 00000001 00000001 00000001]
        /// </summary>
        public const uint Lsb32x8 = (uint)Lsb16x8 | (uint) Lsb16x8 << 16;

        /// <summary>
        /// [00000001 00000001 00000001 00000001 00000001 00000001 00000001 00000001]
        /// </summary>
        public const ulong Lsb64x8 = (ulong)Lsb32x8 | (ulong)Lsb32x8 << 32;

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


        // ~ Lsb2
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// [0101]
        /// </summary>
        public const byte Lsb4x2 = 0b0101;


        /// <summary>
        /// [010101]
        /// </summary>
        public const byte Lsb6x2 = Lsb4x2 | 1 << 4;

        /// <summary>
        /// [01010101]
        /// </summary>
        public const byte Lsb8x2 = Lsb6x2 | 1 << 6;

        /// <summary>
        /// [01 01010101]
        /// </summary>
        public const ushort Lsb10x2 = (ushort)Lsb8x2 | 1 << 8;

        /// <summary>
        /// [0101 01010101]
        /// </summary>
        public const ushort Lsb12x2 = Lsb10x2 | 1 << 10;

        /// <summary>
        /// [010101 01010101]
        /// </summary>
        public const ushort Lsb14x2 = Lsb12x2 | 1 << 12;

        /// <summary>
        /// [01010101 01010101]
        /// </summary>
        public const ushort Lsb16x2 = (ushort)Lsb8x2 | (ushort)Lsb8x2 << 8;

        /// <summary>
        /// [01 01010101 01010101]
        /// </summary>
        public const uint Lsb18x2 = (uint)Lsb16x2 | 1u << 16;

        /// <summary>
        /// [01]
        /// </summary>
        public const uint Lsb32x2 = (uint)Lsb16x2 | (uint)Lsb16x2 << 16;

        /// <summary>
        /// [01]
        /// </summary>
        public const ulong Lsb64x2 = (ulong)Lsb32x2 | (ulong)Lsb32x2 << 32;

        //~ Lsb3

        /// <summary>
        /// [001001]
        /// </summary>
        public const byte Lsb6x3 = 1 | 1 << 3;

        /// <summary>
        /// [001_001_001]
        /// </summary>
        public const ushort Lsb9x3 = Lsb6x3 | 1 << 6;        

        /// <summary>
        /// [0010 01001001]
        /// </summary>
        public const ushort Lsb12x3 = Lsb9x3 | 1 << 9;

        /// <summary>
        /// [0010010 01001001]
        /// </summary>
        public const ushort Lsb15x3 = Lsb12x3 | 1 << 12;

        /// <summary>
        /// [00 10010010 01001001]
        /// </summary>
        public const uint Lsb18x3 = (uint)Lsb15x3 | 1u << 15;
        
        /// <summary>
        /// [00100_10010010_01001001]
        /// </summary>
        public const uint Lsb21x3 = (uint)Lsb18x3 | 1u << 18;        

        /// <summary>
        /// [00100100_10010010_01001001]
        /// </summary>
        public const uint Lsb24x3 = (uint)Lsb21x3 | 1u << 21;   

        /// <summary>
        /// [001_00100100_10010010_01001001]
        /// </summary>
        public const uint Lsb27x3 = (uint)Lsb24x3 | 1u << 24;   

        /// <summary>
        /// [001001_00100100_10010010_01001001]
        /// </summary>
        public const uint Lsb30x3 = (uint)Lsb27x3 | 1u << 27;           

        /// <summary>
        /// [0_01001001_00100100_10010010_01001001]
        /// </summary>
        public const ulong Lsb33x3 = (ulong)Lsb30x3 | 1ul << 30;           

        /// <summary>
        /// [0010_01001001_00100100_10010010_01001001]
        /// </summary>
        public const ulong Lsb36x3 = Lsb33x3 | 1ul << 33;           

        /// <summary>
        /// [0010010_01001001_00100100_10010010_01001001]
        /// </summary>
        public const ulong Lsb39x3 = Lsb36x3 | 1ul << 36;           

        /// <summary>
        /// [0b001_001_001_001_001_001_001_001_001_001_001_001_001_001]
        /// </summary>
        public const ulong Lsb41x3 = Lsb39x3 | 1ul << 39;
            
        /// <summary>
        /// [0b001_001_001_001_001_001_001_001_001_001_001_001_001_001_001]
        /// </summary>
        public const ulong Lsb44x3 = 0b001_001_001_001_001_001_001_001_001_001_001_001_001_001_001;
                
        /// <summary>
        /// [0b001_001_001_001_001_001_001_001_001_001_001_001_001_001_001_001]
        /// </summary>
        public const ulong Lsb48x3 = (ulong)Lsb24x3 | (ulong)Lsb24x3 << 24;                
    
        /// <summary>
        /// [0b001_001_001_001_001_001_001_001_001_001_001_001_001_001_001_001_001]
        /// </summary>
        public const ulong Lsb51x3 = Lsb48x3 | 1ul << 48;

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
        /// [00001 00001]
        /// </summary>
        public const ushort Lsb10x5 = 1 | 1 << 5;

        /// <summary>
        /// [0001 0001 0001]
        /// </summary>
        public const ushort Lsb12x4 = (ushort)Lsb8x4 | 1 << 8;

        /// <summary>
        /// [000001 000001]
        /// </summary>
        public const ushort Lsb12x6 = 1 | 1 << 6;


        /// <summary>
        /// [0000001 0000001]
        /// </summary>
        public const ushort Lsb14x7 = 1 | 1 << 7;


        /// <summary>
        /// [0001 0001 0001 0001]
        /// </summary>
        public const ushort Lsb16x4 = (ushort)Lsb8x4  | (ushort)Lsb8x4 << 8;


        /// <summary>
        /// [000001 000001 000001]
        /// </summary>
        public const uint Lsb18x6 = (uint)Lsb12x6 | 1u << 12;        


        /// <summary>
        /// [00010001 00010001 00010001 00010001]
        /// </summary>
        public const uint Lsb32x4 = (uint)Lsb16x4 | (uint)Lsb16x4 << 16;


        /// <summary>
        /// [00000000 00000001 00000000 00000001]
        /// </summary>
        public const uint Lsb32x16 = 1u | 1u << 16;


        /// <summary>
        /// [00010001 00010001 00010001 00010001 00010001 00010001 00010001 00010001]
        /// </summary>
        public const ulong Lsb64x4 = (ulong)Lsb32x4 | (ulong)Lsb32x4 << 32;

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
        /// [00000000 00000111]
        /// </summary>
        public const ushort Lsb16x16x3 = (ushort)Lsb8x8x3;

        /// <summary>
        /// [01111111 11111111]
        /// </summary>
        public const ushort Lsb16x16x15 = ushort.MaxValue >> 1; 

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
        /// [00000000 00000111 00000000 00000111]
        /// </summary>
        public const uint Lsb32x16x3 = (uint)Lsb16x16x3 | (uint)Lsb16x16x3 << 16;

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

        // ~ Msb2 [10101010]
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// [1010]
        /// </summary>
        public const byte Msb4x2 = 0b1010;

        /// <summary>
        /// [010101]
        /// </summary>
        public const byte Msb6x2 = Msb4x2 | 1 << 4;

        /// <summary>
        /// [10101010]
        /// </summary>
        public const byte Msb8x2 = Lsb8x2 << 1;

        /// <summary>
        /// [10 10101010]
        /// </summary>
        public const ushort Msb10x2 = (ushort)Msb8x2 | 1 << 8;

        /// <summary>
        /// [1010 10101010]
        /// </summary>
        public const ushort Msb12x2 = Msb10x2 | 1 << 10;

        /// <summary>
        /// [101010 10101010]
        /// </summary>
        public const ushort Msb14x2 = Msb12x2 | 1 << 12;

        /// <summary>
        /// [10101010 10101010]
        /// </summary>
        public const ushort Msb16x2 = (ushort)Msb8x2 | (ushort)Msb8x2 << 8;

        /// <summary>
        /// [10 10101010 10101010]
        /// </summary>
        public const uint Msb18x2 = Lsb8x2 << 1;

        /// <summary>
        /// [10101010 10101010 10101010 10101010]
        /// </summary>
        public const uint Msb32x2 = (uint)Msb16x2 | (uint)Msb16x2 << 16;

        /// <summary>
        /// [10101010 10101010 10101010 10101010 10101010 10101010 10101010 10101010]
        /// </summary>
        public const ulong Msb64x2 = Lsb64x2 << 1;

        /// <summary>
        /// [0b100]
        /// </summary>
        public const byte Msb3x1 = 1 << 2;

        /// <summary>
        /// [0b100_100]
        /// </summary>
        public const byte Msb6x3 = Lsb6x3 << 2;

        /// <summary>
        /// [0b100_100_100]
        /// </summary>
        public const ushort Msb9x3 = Lsb9x3 << 2;         

        /// <summary>
        /// [0b100_100_100_100]
        /// </summary>
        public const ushort Msb12x3 = Lsb12x3 << 2;         

        /// <summary>
        /// [0b100_100_100_100_100]
        /// </summary>
        public const ushort Msb15x3 = Lsb15x3 << 2;         

        /// <summary>
        /// [0b100_100_100_100_100_100]
        /// </summary>
        public const uint Msb18x3 = Lsb18x3 << 2;         

        /// <summary>
        /// [0b100_100_100_100_100_100_100]
        /// </summary>
        public const uint Msb21x3 = Lsb21x3 << 2;         


        // ~ Msb4 [11001100]
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// [10001000]
        /// </summary>
        public const byte Msb8x4 = 0b10001000;

        /// <summary>
        /// [10001000 10001000]
        /// </summary>
        public const ushort Msb16x4 = (ushort)Msb8x4  | (ushort)Msb8x4 << 8;

        /// <summary>
        /// [10001000 10001000 10001000 10001000]
        /// </summary>
        public const uint Msb32x4 = (uint)Msb16x4 | (uint)Msb16x4 << 16;

        /// <summary>
        /// [10001000 10001000 10001000 10001000 10001000 10001000 10001000 10001000]
        /// </summary>
        public const ulong Msb64x4 = (ulong)Msb32x4 | (ulong)Msb32x4 << 16;

        /// <summary>
        /// [10000000 10000000]
        /// </summary>
        public const ushort Msb16x8 = (ushort)Msb8 | (ushort)Msb8 << 8 ; 

        /// <summary>
        /// [10000000 10000000 10000000 10000000]
        /// </summary>
        public const uint Msb32x8 = (uint)Msb16x8 | (uint)Msb16x8 << 16;

        /// <summary>
        /// [10000000 00000000 10000000 00000000]
        /// </summary>
        public const uint Msb32x16 = (uint)Msb16 | (uint)Msb16 << 16;

        /// <summary>
        /// [10000000 10000000 10000000 10000000 10000000 10000000 10000000 10000000]
        /// </summary>
        public const ulong Msb64x8 = (ulong)Msb32x8 | (ulong)Msb32x8 << 32;

        /// <summary>
        /// [10000000 00000000 10000000 00000000 10000000 00000000 10000000 00000000]
        /// </summary>
        public const ulong Msb64x16 = (ulong)Msb32x16 | (ulong)Msb32x16 << 32;

        /// <summary>
        /// [10000000 00000000 00000000 0000000 10000000 00000000 00000000 0000000]
        /// </summary>
        public const ulong Msb64x32 =(ulong)Msb32 | (ulong)Msb32 << 32;

        /// <summary>
        /// [0b1100]
        /// </summary>
        public const byte Msb4x1x2 = 0b1100;

        /// <summary>
        /// [0b1100_1100]
        /// </summary>
        public const byte Msb8x2x2 = Msb4x1x2 | Msb4x1x2 << 4;

        /// <summary>
        /// [0b1100_1100_1100]
        /// </summary>
        public const ushort Msb12x3x2 = (ushort)Msb8x2x2 | (ushort)Msb4x1x2 << 8;
        

        // ~ Msb8x2 [11000000]
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// [11000000]
        /// </summary>
        public const byte Msb8x8x2 = 0b11000000;

        /// <summary>
        /// [11000000]
        /// </summary>
        public const ushort Msb16x8x2 = (ushort)Msb8x8x2 | (ushort)Msb8x8x2 << 8;

        /// <summary>
        /// [11000000]
        /// </summary>
        public const uint Msb32x8x2 = (uint)Msb16x8x2 | (uint)Msb16x8x2 << 16;

        /// <summary>
        /// [11000000]
        /// </summary>
        public const ulong Msb64x8x2 = (ulong)Msb32x8x2 | (ulong)Msb32x8x2 << 32;

        // ~ Msb8x3 [11100000]
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// [11100000]
        /// </summary>
        public const byte Msb8x8x3 = 0b11100000;

        /// <summary>
        /// [11100000 11100000]
        /// </summary>
        public const ushort Msb16x8x3 = (ushort)Msb8x8x3 | (ushort)Msb8x8x3 << 8;


        // ~ Msb8x4 [11110000]
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// [11110000]
        /// </summary>
        public const byte Msb8x8x4 = 0b11110000;

        /// <summary>
        /// [11110000 11110000]
        /// </summary>
        public const ushort Msb16x8x4 = (ushort)Msb8x8x4 | (ushort)Msb8x8x4 << 8;


        // ~ Msb8x6 [11111100]
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// [11111100]
        /// </summary>
        public const byte Msb8x8x6 = 0b11111100;

        // ~ Msb8x7 [11111110]
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// [11111110]
        /// </summary>
        public const byte Msb8x8x7 = 0b11111110;

        /// <summary>
        /// [11111110 11111110]
        /// </summary>
        public const ushort Msb16x8x7 = (ushort)Msb8x8x7 | (ushort)Msb8x8x7 << 8;

        /// <summary>
        /// [11111110 11111110 11111110 11111110]
        /// </summary>
        public const uint Msb32x8x7 = (uint)Msb16x8x7 | (uint)Msb16x8x7 << 16;

        // ~ Msb8x5 [11111000]
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// [11111000]
        /// </summary>
        public const byte Msb8x8x5 = 0b11111000;

        /// <summary>
        /// [11111000 11111000]
        /// </summary>
        public const ushort Msb16x8x5 = (ushort)Msb8x8x5 | (ushort)Msb8x8x5 << 8;

        /// <summary>
        /// [11111000 11111000 11111000 11111000]
        /// </summary>
        public const uint Msb32x8x5 = (uint)Msb16x8x5 | (uint)Msb16x8x5 << 16;

        /// <summary>
        /// [11111000 11111000 11111000 11111000 11111000 11111000 11111000 11111000]
        /// </summary>
        public const ulong Msb64x8x5 = (ulong)Msb32x8x5 | (ulong)Msb32x8x5 << 32;

        /// <summary>
        /// [11111100 11111100]
        /// </summary>
        public const ushort Msb16x8x6 = (ushort)Msb8x8x6 | (ushort)Msb8x8x6 << 8;

        /// <summary>
        /// [11100000 11100000 11100000 11100000]
        /// </summary>
        public const uint Msb32x8x3 = (uint)Msb16x8x3 | (uint)Msb16x8x3 << 16;

        /// <summary>
        /// [11110000 11110000 11110000 11110000]
        /// </summary>
        public const uint Msb32x8x4 = (uint)Msb16x8x4 | (uint)Msb16x8x4 << 16;

        /// <summary>
        /// [11111100 11111100 11111100 11111100]
        /// </summary>
        public const uint Msb32x8x6 = (uint)Msb16x8x6 | (uint)Msb16x8x6 << 16;


        /// <summary>
        /// [11100000 11100000 11100000 11100000 11100000 11100000 11100000 11100000]
        /// </summary>
        public const ulong Msb64x8x3 = (ulong)Msb32x8x3 | (ulong)Msb32x8x3 << 32;

        /// <summary>
        /// [11110000 11110000 11110000 11110000 11110000 11110000 11110000 11110000]
        /// </summary>
        public const ulong Msb64x8x4 = (ulong)Msb32x8x4 | (ulong)Msb32x8x4 << 32;


        /// <summary>
        /// [11111100 11111100 11111100 11111100 11111100 11111100 11111100 11111100]
        /// </summary>
        public const ulong Msb64x8x6 = (ulong)Msb32x8x6 | (ulong)Msb32x8x6 << 32;

        /// <summary>
        /// [11111110 11111110 11111110 11111110 11111110 11111110 11111110 11111110]
        /// </summary>
        public const ulong Msb64x8x7 = (ulong)Msb32x8x7 | (ulong)Msb32x8x7 << 32;

        // ~ Even [01010101]
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// [01010101]
        /// </summary>
        public const byte Even8 = Lsb8x2;

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
        public const byte Odd8 = Msb8x2;

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

        /// <summary>
        /// [10000001]
        /// </summary>
        public const byte Jsb8x8x1 = Lsb8 | Msb8;

        /// <summary>
        /// [10000001 10000001]
        /// </summary>
        public const ushort Jsb16x8x1 = (ushort)Jsb8x8x1 | (ushort)Jsb8x8x1 << 8;

        /// <summary>
        /// [10000001 10000001 10000001 10000001]
        /// </summary>
        public const uint Jsb32x8x1 = (uint)Jsb16x8x1 | (uint)Jsb16x8x1 << 16;

        /// <summary>
        /// [10000001 10000001 10000001 10000001]
        /// </summary>
        public const ulong Jsb64x8x1 = (ulong)Jsb32x8x1 | (ulong)Jsb32x8x1 << 32;

        // ~ Jsb8x2 [11000011]
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// [11000011]
        /// </summary>
        public const byte Jsb8x8x2 = Lsb8x8x2 | Msb8x8x2;

        /// <summary>
        /// [11000011 11000011]
        /// </summary>
        public const ushort Jsb16x8x2 = (ushort)Jsb8x8x2 | (ushort)Jsb8x8x2 << 8;

        /// <summary>
        /// [11000011 11000011 11000011 11000011]
        /// </summary>
        public const uint Jsb32x8x2 = (uint)Jsb16x8x2 | (uint)Jsb16x8x2 << 16;

        /// <summary>
        /// [11000011 11000011 11000011 11000011 11000011 11000011 11000011 11000011]
        /// </summary>
        public const ulong Jsb64x8x2 = (ulong)Jsb32x8x2 | (ulong)Jsb32x8x2 << 32;

        // ~ Jsb8x3 [11100111]
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// [11100111]
        /// </summary>
        public const byte Jsb8x8x3 = Lsb8x8x3 | Msb8x8x3;

        /// <summary>
        /// [11100111 11100111]
        /// </summary>
        public const ushort Jsb16x8x3 = (ushort)Jsb8x8x3 | (ushort)Jsb8x8x3 << 8;

        /// <summary>
        /// [11100111 11100111 11100111 11100111]
        /// </summary>
        public const uint Jsb32x8x3 = (uint)Jsb16x8x3 | (uint)Jsb16x8x3 << 16;

        /// <summary>
        /// [11100111 11100111 11100111 11100111]
        /// </summary>
        public const ulong Jsb64x8x3 = (ulong)Jsb32x8x3 | (ulong)Jsb32x8x3 << 32;

        // ~ Central8x2 [00011000]
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// [00011000] 
        /// </summary>
        public const byte Central8x8x2 = 0b00011000;

        /// <summary>
        /// [00011000 00011000]
        /// </summary>
        public const ushort Central16x8x2 = (ushort)Central8x8x2 | (ushort)Central8x8x2 << 8;

        /// <summary>
        /// [00011000 00011000 00011000 00011000]
        /// </summary>
        public const uint Central32x8x2 = (uint)Central16x8x2 | (uint)Central16x8x2 << 8;

        /// <summary>
        /// [00011000 00011000 00011000 00011000 00011000 00011000 00011000 00011000]
        /// </summary>
        public const ulong Central64x8x2 = (ulong)Central32x8x2 | (ulong)Central32x8x2 << 8;

        // ~ Central8x4 [00111100]
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// [00111100]
        /// </summary>
        public const byte Central8x8x4 = 0b00111100;

        /// <summary>
        /// [00111100 00111100]
        /// </summary>
        public const ushort Central16x8x4 = (ushort)Central8x8x4 | (ushort)Central8x8x4 << 8;

        /// <summary>
        /// [00111100 00111100 00111100 00111100]
        /// </summary>
        public const uint Central32x8x4 = (uint)Central16x8x4 | (uint)Central16x8x4 << 8;

        /// <summary>
        /// [00111100 00111100 00111100 00111100 00111100 00111100 00111100 00111100]
        /// </summary>
        public const ulong Central64x8x4 = (ulong)Central32x8x4 | (ulong)Central32x8x4 << 8;

        // ~ Central8x6 [01111110]
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// [01111110]
        /// </summary>
        public const byte Central8x8x6 = 0b01111110;

        /// <summary>
        /// [01111110 01111110]
        /// </summary>
        public const ushort Central16x8x6 = (ushort)Central8x8x6 | (ushort)Central8x8x6 << 8;

        /// <summary>
        /// [01111110 01111110 01111110 01111110]
        /// </summary>
        public const uint Central32x8x6 = (uint)Central16x8x6 | (uint)Central16x8x6 << 16;

        /// <summary>
        /// [01111110 01111110 01111110 01111110 01111110 01111110 01111110 01111110]
        /// </summary>
        public const ulong Central64x8x6 = (ulong)Central32x8x6 | (ulong)Central32x8x6 << 32;

        /// <summary>
        /// [00000001 10000000]
        /// </summary>
        public const ushort Central16x16x2 = (ushort) Msb8 | (ushort)Lsb8 << 8;

        /// <summary>
        /// [00000001 10000000 00000001 10000000]
        /// </summary>
        public const uint Central32x16x2 = (uint) Central16x16x2 | (uint)Central16x16x2 << 16;

        /// <summary>
        /// [00000001 10000000 00000001 10000000 00000001 10000000 00000001 10000000]
        /// </summary>
        public const ulong Central64x16x2 = (ulong) Central32x16x2 | (ulong)Central32x16x2 << 32;

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
        public const ushort Central16x16x8 = (ushort) Msb8x8x4 | (ushort)Lsb8x8x4 << 8; 

        /// <summary>
        /// [00001111 11110000 00001111 11110000]
        /// </summary>
        public const uint Central32x16x8 = (uint) Central16x16x8 | (uint)Central16x16x8 << 16; 

        /// <summary>
        /// [00001111 11110000 00001111 11110000]
        /// </summary>
        public const ulong Central64x16x8 = (ulong) Central32x16x8 | (ulong)Central32x16x8 << 32; 

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
        /// [00000000 00000001 10000000 00000000]
        /// </summary>
        public const uint Central32x2 = (uint) Msb16 | (uint)Lsb16 << 8;

        // ~ CJsb8x2x1 [10011001]
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// [10011001]
        /// </summary>
        public const byte CJsb8x8x2x1 = Central8x8x2 | Jsb8x8x1;

        /// <summary>
        /// [10011001 10011001]
        /// </summary>
        public const ushort CJsb16x8x2x1 = (ushort)CJsb8x8x2x1 | (ushort)CJsb8x8x2x1 << 8;

        /// <summary>
        /// [10011001 10011001 10011001 10011001]
        /// </summary>
        public const uint CJsb32x8x2x1 = (uint)CJsb16x8x2x1 | (uint)CJsb16x8x2x1 << 16;

        /// <summary>
        /// [10011001 10011001 10011001 10011001 10011001 10011001 10011001 10011001]
        /// </summary>
        public const ulong CJsb64x8x2x1 = (ulong)CJsb32x8x2x1 | (ulong)CJsb32x8x2x1 << 32;

        // ~ CJsb8x2x2 [11011011]
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// [0b11011011]
        /// </summary>
        public const byte CJsb8x8x2x2 = Central8x8x2 | Jsb8x8x2;

        /// <summary>
        /// [0b11011011_11011011]
        /// </summary>
        public const ushort CJsb16x8x2x2 = (ushort)CJsb8x8x2x2 | (ushort)CJsb8x8x2x2 << 8;

        /// <summary>
        /// [0b11011011_11011011_11011011_11011011]
        /// </summary>
        public const uint CJsb32x8x2x2 = (uint)CJsb16x8x2x2 | (uint)CJsb16x8x2x2 << 16;

        /// <summary>
        /// [0b11011011_11011011_11011011_11011011_11011011_11011011_11011011_11011011]
        /// </summary>
        public const ulong CJsb64x8x2x2 = (ulong)CJsb32x8x2x2 | (ulong)CJsb32x8x2x2 << 32;

        // ~ CJsb8x4 [10111101]
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// [10111101]
        /// </summary>
        public const byte CJsb8x8x4x1 = Central8x8x4 | Jsb8x8x1;

        /// <summary>
        /// [10111101 10111101]
        /// </summary>
        public const ushort CJsb16x8x4x1 = (ushort)CJsb8x8x4x1 | (ushort)CJsb8x8x2x1 << 8;

        /// <summary>
        /// [10111101 10111101 10111101 10111101]
        /// </summary>
        public const uint CJsb32x8x4x1 = (uint)CJsb16x8x4x1 | (uint)CJsb16x8x2x1 << 16;

        /// <summary>
        /// [10111101 10111101 10111101 10111101]
        /// </summary>
        public const ulong CJsb64x8x4x1 = (ulong)CJsb32x8x4x1 | (ulong)CJsb32x8x2x1 << 32;

    }


}
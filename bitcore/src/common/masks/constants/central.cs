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
        public const ushort Central16x16x2 = (ushort) Msb8x8x1 | (ushort)Lsb8x1x1 << 8;

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
        public const uint Central32x2 = (uint) Msb16x16x1 | (uint)Lsb16x16x1 << 8;
    }
}
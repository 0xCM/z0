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

    partial class BitMask
    {
        /// <summary>
        /// Defines an 8 bit pattern where the lsb is enabled
        /// </summary>
        public const byte Lsb8x1 = 1 << 0;

        /// <summary>
        /// Defines a 8 bit pattern of the form [0001 0001] where the lsb  of each 4-bit segment is enabled
        /// </summary>
        public const byte Lsb8x2  = 1 << 0  | 1 << 4;

        /// <summary>
        /// Defines an 8-bit pattern of the form [01 01 01 01] where the lsb of each 2-bit segment is enabled
        /// </summary>
        public const byte Lsb8x4 = 1 | 1 << 2 | 1 << 4 | 1 << 6;

        /// <summary>
        /// Defines a 16-bit pattern where the lsb is enabled
        /// </summary>
        public const ushort Lsb16x1 = 1;

        /// <summary>
        /// Defines a 16 bit pattern of the form [0b00000001, 0b00000001]
        /// </summary>
        public const ushort Lsb16x2 = (ushort)Lsb8x1 | (ushort) Lsb8x1 << 8;

        /// <summary>
        /// Defines a 16 bit pattern of the form [0001 ... 0001] where the lsb of each 4-bit segment is enabled
        /// </summary>
        public const ushort Lsb16x4 = (ushort)Lsb8x2  | (ushort)Lsb8x2 << 8;

        /// <summary>
        /// Defines a 16-bit pattern of the form [01 01 ... 01 01] where the lsb of each 2-bit segment is enabled
        /// </summary>
        public const ushort Lsb16x8 = (ushort)Lsb8x4 | (ushort)Lsb8x4 << 8;

        /// <summary>
        /// Defines a 32-bit pattern where the lsb is enabled
        /// </summary>
        public const uint Lsb32x1 = 1;

        /// <summary>
        /// Defines a 32-bit pattern of the form [00000000_00000001 00000000_00000001] where the lsb of each 16-bit segment is enabled
        /// </summary>
        public const uint Lsb32x2 = (uint)Lsb16x1 | (uint)Lsb16x1 << 16;

        /// <summary>
        /// Defines a 32 bit pattern of the form [0b00000001, ..., 0b00000001] where the least bit of each 8-bit segment is enaabled
        /// </summary>
        public const uint Lsb32x4 = (uint) Lsb16x2 | (uint) Lsb16x2 << 16;

        /// <summary>
        /// Defines a 32 bit pattern of the form [0001 ... 0001] where the lsb of each 4-bit segment is enabled
        /// </summary>
        public const uint Lsb32x8 = (uint)Lsb16x4 | (uint)Lsb16x4 << 16;

        /// <summary>
        /// Defines a 32-bit pattern of the form [01 01 ... 01 01] where the lsb of each 2-bit segment is enabled
        /// </summary>
        public const uint Lsb32x16 = (uint)Lsb16x8 | (uint)Lsb16x8 << 16;

        /// <summary>
        /// Defines a 64-bit pattern where the least significant bit is enabled
        /// </summary>
        public const ulong Lsb64x1 = 1;

        /// <summary>
        /// Defines a 64-bit pattern where the lsb of each 32-bit segment is enabled
        /// </summary>
        public const ulong Lsb64x2 = (ulong)Lsb32x1 | (ulong) Lsb32x1 << 32;

        /// <summary>
        /// Defines a 64-bit pattern of the form [00000000_00000001 ... 00000000_00000001] where the lsb of each 16-bit segment is enabled
        /// </summary>
        public const ulong Lsb64x4 = (ulong)Lsb32x2 | (ulong)Lsb32x2 << 32;

        /// <summary>
        /// Defines a 64 bit pattern of the form [0b00000001, ..., 0b00000001]
        /// </summary>
        public const ulong Lsb64x8 = (ulong)Lsb32x4 | (ulong)Lsb32x4 << 32;
                         
        /// <summary>
        /// Defines a 64 bit pattern of the form [0001 ... 0001] where the lsb of each 4-bit segment is enabled
        /// </summary>
        public const ulong Lsb64x16 = (ulong)Lsb32x8 | (ulong)Lsb32x8 << 32;

        /// <summary>
        /// Defines a 64-bit pattern of the form [01 01 ... 01 01] where the lsb of each 2-bit segment is enabled
        /// </summary>
        public const ulong Lsb64x32 = (ulong)Lsb32x16 | (ulong)Lsb32x16 << 32;
            
        /// <summary>
        /// Defines an 8 bit pattern where the msb is enabled
        /// </summary>
        public const byte Msb8x1 = 128 << 0; 

        /// <summary>
        /// Defines a 16 bit pattern of the form [10000000 10000000]
        /// </summary>
        public const ushort Msb16x2  = (ushort)Msb8x1 | (ushort)Msb8x1 << 8 ; 

        /// <summary>
        /// Defines a 32 bit pattern of the form [10000000 ... 10000000]
        /// </summary>
        public const uint Msb32x4  = (uint)Msb16x2 | (uint)Msb16x2 << 16;

        /// <summary>
        /// Defines a 64 bit pattern of the form [10000000 ... 10000000]
        /// </summary>
        public const ulong Msb64x8  = (ulong) Msb32x4 | (ulong)Msb32x4 << 32;

        /// <summary>
        /// Defines a 16-bit pattern where the msb is enabled
        /// </summary>
        public const ushort Msb16x1 = 1 << 15;

        /// <summary>
        /// Defines a 32-bit pattern where the msb is enabled
        /// </summary>
        public const uint Msb32x1 = 1u << 31;

        /// <summary>
        /// Defines a 64-bit pattern where the most significant bit is enabled
        /// </summary>
        public const ulong Msb64x1 = 1ul << 63;

        /// <summary>
        /// Defines an 8-bit pattern of the form [10 10 10 10] where the msb of each 2-bit segment is enabled
        /// </summary>
        public const byte Msb8x4 = Lsb8x4 << 1;

        /// <summary>
        /// Defines a 16-bit pattern of the form [10 10 ... 10 10] where the msb of each 2-bit segment is enabled
        /// </summary>
        public const ushort Msb16x8 = Lsb16x8 << 1;

        /// <summary>
        /// Defines an 32-bit pattern of the form [10 10 ... 10 10] where the msb of each 2-bit segment is enabled
        /// </summary>
        public const uint Msb32x2 = Lsb32x16 << 1;

        /// <summary>
        /// Defines an 64-bit pattern of the form [10 10 ... 10 10] where the msb of each 2-bit segment is enabled
        /// </summary>
        public const ulong Msb64x2 = Lsb64x32 << 1;
    }

}
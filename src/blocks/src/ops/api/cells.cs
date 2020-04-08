//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using static Seed;        

    partial class Blocks
    {
        /// <summary>
        /// Creates a 8-bit blocked container from 1 8-bit cell
        /// </summary>
        [MethodImpl(Inline), Op]
        public static Block8<byte> cells(W8 n, byte src)
            => new Block8<byte>(src);

        /// <summary>
        /// Creates a 16-bit blocked container from 1 16-bit cell
        /// </summary>
        [MethodImpl(Inline), Op]
        public static Block16<ushort> cells(W16 n, ushort src)
            => new Block16<ushort>(src);

        /// <summary>
        /// Creates a 16-bit blocked container from 1 64-bit cell
        /// </summary>
        [MethodImpl(Inline), Op]
        public static Block16<ulong> cells(W16 n, ulong src)
            => new Block16<ulong>(src);

        /// <summary>
        /// Creates a 32-bit blocked container from 1 64-bit cell
        /// </summary>
        [MethodImpl(Inline), Op]
        public static Block32<ulong> cells(W32 n, ulong x0)
            => new Block32<ulong>(x0);

        /// <summary>
        /// Creates a 32-bit blocked container from 4 8-bit cells
        /// </summary>
        [MethodImpl(Inline), Op]
        public static Block32<byte> cells(W32 n, byte x0, byte x1, byte x2, byte x3)
            => new Block32<byte>(x0,x1,x2,x3);

        /// <summary>
        /// Creates a 32-bit blocked container from 2 16-bit cells
        /// </summary>
        [MethodImpl(Inline), Op]
        public static Block32<ushort> cells(W32 n, ushort x0, ushort x1)
            => new Block32<ushort>(x0,x1);

        /// <summary>
        /// Creates a 32-bit blocked container from 1 32-bit cell
        /// </summary>
        [MethodImpl(Inline), Op]
        public static Block32<uint> cells(W32 n, uint x0)
            => new Block32<uint>(x0);

        /// <summary>
        /// Creates a 64-bit blocked container from 8 8-bit cells
        /// </summary>
        [MethodImpl(Inline), Op]
        public static Block64<byte> cells(W64 w, byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7)
                => new Block64<byte>(x0,x1,x2,x3,x4,x5,x6,x7);

        /// <summary>
        /// Creates a 64-bit blocked container from 4 16-bit cells
        /// </summary>
        [MethodImpl(Inline), Op]
        public static Block64<ushort> cells(W64 w, ushort x0, ushort x1, ushort x2, ushort x3)
            => new Block64<ushort>(x0,x1,x2,x3);

        /// <summary>
        /// Creates a 64-bit data block from 2 32-bit cells
        /// </summary>
        [MethodImpl(Inline), Op]
        public static Block64<uint> cells(W64 w, uint x0, uint x1)
            => new Block64<uint>(x0,x1);

        /// <summary>
        /// Creates a 64-bit data block from 1 64-bit cell
        /// </summary>
        [MethodImpl(Inline), Op]
        public static Block64<ulong> cells(W64 w, ulong x0)
            => new Block64<ulong>(x0);

        /// <summary>
        /// Creates a 128-bit blocked span from 8-bit cells
        /// </summary>
        [MethodImpl(Inline), Op]
        public static Block128<byte> cells(W128 n, 
            byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7, 
            byte x8, byte x9, byte xA, byte xB, byte xC, byte xD, byte xE, byte xF)
                => new Block128<byte>(x0,x1,x2,x3,x4,x5,x6,x7,x8,x9,xA,xB,xC,xD,xE,xF);

        /// <summary>
        /// Creates a 128-bit blocked span from 16-bit cells
        /// </summary>
        [MethodImpl(Inline), Op]
        public static Block128<ushort> cells(W128 n, 
            ushort x0, ushort x1, ushort x2, ushort x3, ushort x4, ushort x5, ushort x6, ushort x7)            
                => new Block128<ushort>(x0,x1,x2,x3,x4,x5,x6,x7);

        /// <summary>
        /// Creates a 128-bit blocked span from 4 32-bit cells
        /// </summary>
        [MethodImpl(Inline), Op]
        public static Block128<uint> cells(W128 n, uint x0, uint x1, uint x2, uint x3)            
            => new Block128<uint>(x0,x1,x2,x3);

        /// <summary>
        /// Creates a 128-bit blocked container from 2 64-bit cells
        /// </summary>
        [MethodImpl(Inline), Op]
        public static Block128<ulong> cells(W128 w, ulong x0, ulong x1)            
            => new Block128<ulong>(x0,x1);

        /// <summary>
        /// Creates a 256-bit blocked container from 32 8-bit cells
        /// </summary>
        [MethodImpl(Inline), Op]
        public static Block256<byte> cells(W256 w, 
            byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7, 
            byte x8, byte x9, byte xA, byte xB, byte xC, byte xD, byte xE, byte xF,
            byte x10, byte x11, byte x12, byte x13, byte x14, byte x15, byte x16, byte x17,
            byte x18, byte x19, byte x1A, byte x1B, byte x1C, byte x1D, byte x1E, byte x1F)
                => new Block256<byte>(x0,x1,x2,x3,x4,x5,x6,x7,x8,x9,xA,xB,xC,xD,xE,xF,
                    x10,x11,x12,x13,x14,x15,x16,x17,x18, x19,x1A,x1B,x1C,x1D,x1E,x1F);

        /// <summary>
        /// Creates a 256-bit blocked container from 16 16-bit cells
        /// </summary>
        [MethodImpl(Inline), Op]
        public static Block256<ushort> cells(W256 n, 
            ushort x0, ushort x1, ushort x2, ushort x3, ushort x4, ushort x5, ushort x6, ushort x7, 
            ushort x8, ushort x9, ushort xA, ushort xB, ushort xC, ushort xD, ushort xE, ushort xF)
                => new Block256<ushort>(x0,x1,x2,x3,x4,x5,x6,x7,x8,x9,xA,xB,xC,xD,xE,xF);

        /// <summary>
        /// Creates a 256-bit blocked container from 8 32-bit cells
        /// </summary>
        [MethodImpl(Inline), Op]
        public static Block256<uint> cells(W256 n, 
            uint x0, uint x1, uint x2, uint x3, uint x4, uint x5, uint x6, uint x7)
                => new Block256<uint>(x0,x1,x2,x3,x4,x5,x6,x7);

        /// <summary>
        /// Creates a 256-bit blocked container from 4 64-bit cells
        /// </summary>
        [MethodImpl(Inline), Op]
        public static Block256<ulong> cells(W256 n, ulong x0, ulong x1, ulong x2, ulong x3)
            => new Block256<ulong>(x0,x1,x2,x3);


        /// <summary>
        /// Creates a 512-bit blocked container from 8 64-bit cells
        /// </summary>
        [MethodImpl(Inline), Op]
        public static Block512<ulong> cells(W512 w, ulong x0, ulong x1, ulong x2, ulong x3, ulong x4, ulong x5, ulong x6, ulong x7)
            => new Block512<ulong>(x0,x1,x2,x3,x4,x5,x6,x7);

        /// <summary>
        /// Creates a 512-bit blocked container from 16 32-bit cells
        /// </summary>
        [MethodImpl(Inline), Op]
        public static Block512<uint> cells(W512 n, 
            uint x0, uint x1, uint x2, uint x3, uint x4, uint x5, uint x6, uint x7, 
            uint x8, uint x9, uint xA, uint xB, uint xC, uint xD, uint xE, uint xF)
                => new Block512<uint>(x0,x1,x2,x3,x4,x5,x6,x7,x8,x9,xA,xB,xC,xD,xE,xF);
    }
}
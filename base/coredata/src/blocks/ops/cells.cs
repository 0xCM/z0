//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
        
    using static zfunc;

    partial class DataBlocks
    {
        /// <summary>
        /// Creates a 16-bit blocked container from 1 16-bit cell
        /// </summary>
        [MethodImpl(Inline)]
        public static Block16<ushort> cells(N16 n, ushort x0)
            => parts(n,x0);

        /// <summary>
        /// Creates a 16-bit blocked container from 1 64-bit cell
        /// </summary>
        [MethodImpl(Inline)]
        public static Block16<ulong> cells(N16 n, ulong x0)
            => parts(n,x0);

        /// <summary>
        /// Creates a 32-bit blocked container from 1 64-bit cell
        /// </summary>
        [MethodImpl(Inline)]
        public static Block32<ulong> cells(N32 n, ulong x0)
            => parts(n,x0);

        /// <summary>
        /// Creates a 32-bit blocked container from 4 8-bit cells
        /// </summary>
        [MethodImpl(Inline)]
        public static Block32<byte> cells(N32 n, byte x0, byte x1, byte x2, byte x3)
            => parts(n,x0,x1,x2,x3);

        /// <summary>
        /// Creates a 32-bit blocked container from 2 16-bit cells
        /// </summary>
        [MethodImpl(Inline)]
        public static Block32<ushort> cells(N32 n, ushort x0, ushort x1)
            => parts(n,x0,x1);

        /// <summary>
        /// Creates a 32-bit blocked container from 1 32-bit cell
        /// </summary>
        [MethodImpl(Inline)]
        public static Block32<uint> cells(N32 n, uint x0)
            => parts(n,x0);

        /// <summary>
        /// Creates a 64-bit blocked container from 8 8-bit cells
        /// </summary>
        [MethodImpl(Inline)]
        public static Block64<byte> cells(N64 n, 
            byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7)
                => parts(n,x0,x1,x2,x3,x4,x5,x6,x7);

        /// <summary>
        /// Creates a 64-bit blocked container from 4 16-bit cells
        /// </summary>
        [MethodImpl(Inline)]
        public static Block64<ushort> cells(N64 n, ushort x0, ushort x1, ushort x2, ushort x3)
            => parts(n,x0,x1,x2,x3);

        /// <summary>
        /// Creates a 64-bit data block from 2 32-bit cells
        /// </summary>
        [MethodImpl(Inline)]
        public static Block64<uint> cells(N64 n, uint x0, uint x1)
            => parts(n,x0,x1);

        /// <summary>
        /// Creates a 64-bit data block from 1 64-bit cell
        /// </summary>
        [MethodImpl(Inline)]
        public static Block64<ulong> cells(N64 n, ulong x0)
            => parts(n,x0);

        /// <summary>
        /// Creates a 128-bit blocked span from 8-bit cells
        /// </summary>
        [MethodImpl(Inline)]
        public static Block128<byte> cells(N128 n, 
            byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7, 
            byte x8, byte x9, byte xA, byte xB, byte xC, byte xD, byte xE, byte xF)
                => parts(n,x0,x1,x2,x3,x4,x5,x6,x7,x8,x9,xA,xB,xC,xD,xE,xF);

        /// <summary>
        /// Creates a 128-bit blocked span from 16-bit cells
        /// </summary>
        [MethodImpl(Inline)]
        public static Block128<ushort> cells(N128 n, 
            ushort x0, ushort x1, ushort x2, ushort x3, ushort x4, ushort x5, ushort x6, ushort x7)            
                => parts(n,x0,x1,x2,x3,x4,x5,x6,x7);

        /// <summary>
        /// Creates a 128-bit blocked span from 4 32-bit cells
        /// </summary>
        [MethodImpl(Inline)]
        public static Block128<uint> cells(N128 n, uint x0, uint x1, uint x2, uint x3)            
            => parts(n,x0,x1,x2,x3);

        /// <summary>
        /// Creates a 128-bit blocked container from 2 64-bit cells
        /// </summary>
        [MethodImpl(Inline)]
        public static Block128<ulong> cells(N128 n, ulong x0, ulong x1)            
            => parts(n,x0,x1);

        /// <summary>
        /// Creates a 256-bit blocked container from 32 8-bit cells
        /// </summary>
        [MethodImpl(Inline)]
        public static Block256<byte> cells(N256 n, 
            byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7, 
            byte x8, byte x9, byte xA, byte xB, byte xC, byte xD, byte xE, byte xF,
            byte x10, byte x11, byte x12, byte x13, byte x14, byte x15, byte x16, byte x17,
            byte x18, byte x19, byte x1A, byte x1B, byte x1C, byte x1D, byte x1E, byte x1F)
                => parts(n,x0,x1,x2,x3,x4,x5,x6,x7,x8,x9,xA,xB,xC,xD,xE,xF,
                    x10,x11,x12,x13,x14,x15,x16,x17,x18, x19,x1A,x1B,x1C,x1D,x1E,x1F);

        /// <summary>
        /// Creates a 256-bit blocked container from 16 16-bit cells
        /// </summary>
        [MethodImpl(Inline)]
        public static Block256<ushort> cells(N256 n, 
            ushort x0, ushort x1, ushort x2, ushort x3, ushort x4, ushort x5, ushort x6, ushort x7, 
            ushort x8, ushort x9, ushort xA, ushort xB, ushort xC, ushort xD, ushort xE, ushort xF)
                => parts(n,x0,x1,x2,x3,x4,x5,x6,x7,x8,x9,xA,xB,xC,xD,xE,xF);

        /// <summary>
        /// Creates a 256-bit blocked container from 8 32-bit cells
        /// </summary>
        [MethodImpl(Inline)]
        public static Block256<uint> cells(N256 n, 
            uint x0, uint x1, uint x2, uint x3, uint x4, uint x5, uint x6, uint x7)
                => parts(n,x0,x1,x2,x3,x4,x5,x6,x7);

        /// <summary>
        /// Creates a 256-bit blocked container from 4 64-bit cells
        /// </summary>
        [MethodImpl(Inline)]
        public static Block256<ulong> cells(N256 n, ulong x0, ulong x1, ulong x2, ulong x3)
            => parts(n,x0,x1,x2,x3);

    }

}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct BufferBlocks
    {
        /// <summary>
        /// Creates a 8-bit blocked container from 1 8-bit cell
        /// </summary>
        [MethodImpl(Inline), Op]
        public static SpanBlock8<byte> create(W8 n, byte src)
            => new SpanBlock8<byte>(z.cover(src,1));

        /// <summary>
        /// Creates a 16-bit blocked container from 1 16-bit cell
        /// </summary>
        [MethodImpl(Inline), Op]
        public static SpanBlock16<ushort> create(W16 n, ushort src)
            => new SpanBlock16<ushort>(z.cover(src,1));

        /// <summary>
        /// Creates a 16-bit blocked container from 1 64-bit cell
        /// </summary>
        [MethodImpl(Inline), Op]
        public static SpanBlock16<ulong> create(W16 n, ulong src)
            => new SpanBlock16<ulong>(z.cover(src,1));

        /// <summary>
        /// Creates a 32-bit blocked container from 1 64-bit cell
        /// </summary>
        [MethodImpl(Inline), Op]
        public static SpanBlock32<ulong> create(W32 n, ulong src)
            => new SpanBlock32<ulong>(z.cover(src,1));

        /// <summary>
        /// Creates a 32-bit blocked container from 4 8-bit cells
        /// </summary>
        [MethodImpl(Inline), Op]
        public static SpanBlock32<byte> create(W32 n, byte x0, byte x1, byte x2, byte x3)
        {
            var dst = 0u;
            seek8(dst,0) = x0;
            seek8(dst,1) = x1;
            seek8(dst,2) = x2;
            seek8(dst,3) = x3;
            return new SpanBlock32<byte>(cover(@as<byte>(dst),4));
        }

        /// <summary>
        /// Creates a 32-bit blocked container from 2 16-bit cells
        /// </summary>
        [MethodImpl(Inline), Op]
        public static SpanBlock32<ushort> create(W32 n, ushort x0, ushort x1)
            => new SpanBlock32<ushort>(x0,x1);

        /// <summary>
        /// Creates a 32-bit blocked container from 1 32-bit cell
        /// </summary>
        [MethodImpl(Inline), Op]
        public static SpanBlock32<uint> create(W32 n, uint x0)
            => new SpanBlock32<uint>(x0);

        /// <summary>
        /// Creates a 64-bit blocked container from 8 8-bit cells
        /// </summary>
        [MethodImpl(Inline), Op]
        public static SpanBlock64<byte> create(W64 w, byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7)
                => new SpanBlock64<byte>(x0,x1,x2,x3,x4,x5,x6,x7);

        /// <summary>
        /// Creates a 64-bit blocked container from 4 16-bit cells
        /// </summary>
        [MethodImpl(Inline), Op]
        public static SpanBlock64<ushort> create(W64 w, ushort x0, ushort x1, ushort x2, ushort x3)
            => new SpanBlock64<ushort>(x0,x1,x2,x3);

        /// <summary>
        /// Creates a 64-bit data block from 2 32-bit cells
        /// </summary>
        [MethodImpl(Inline), Op]
        public static SpanBlock64<uint> create(W64 w, uint x0, uint x1)
            => new SpanBlock64<uint>(x0,x1);

        /// <summary>
        /// Creates a 64-bit data block from 1 64-bit cell
        /// </summary>
        [MethodImpl(Inline), Op]
        public static SpanBlock64<ulong> create(W64 w, ulong x0)
            => new SpanBlock64<ulong>(x0);

        /// <summary>
        /// Creates a 128-bit blocked span from 8-bit cells
        /// </summary>
        [MethodImpl(Inline), Op]
        public static SpanBlock128<byte> create(W128 n,
            byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7,
            byte x8, byte x9, byte xA, byte xB, byte xC, byte xD, byte xE, byte xF)
                => new SpanBlock128<byte>(x0,x1,x2,x3,x4,x5,x6,x7,x8,x9,xA,xB,xC,xD,xE,xF);

        /// <summary>
        /// Creates a 128-bit blocked span from 16-bit cells
        /// </summary>
        [MethodImpl(Inline), Op]
        public static SpanBlock128<ushort> create(W128 n,
            ushort x0, ushort x1, ushort x2, ushort x3, ushort x4, ushort x5, ushort x6, ushort x7)
                => new SpanBlock128<ushort>(x0,x1,x2,x3,x4,x5,x6,x7);

        /// <summary>
        /// Creates a 128-bit blocked span from 4 32-bit cells
        /// </summary>
        [MethodImpl(Inline), Op]
        public static SpanBlock128<uint> create(W128 n, uint x0, uint x1, uint x2, uint x3)
            => new SpanBlock128<uint>(x0,x1,x2,x3);

        /// <summary>
        /// Creates a 128-bit blocked container from 2 64-bit cells
        /// </summary>
        [MethodImpl(Inline), Op]
        public static SpanBlock128<ulong> create(W128 w, ulong x0, ulong x1)
            => new SpanBlock128<ulong>(x0,x1);

        /// <summary>
        /// Creates a 256-bit blocked container from 32 8-bit cells
        /// </summary>
        [MethodImpl(Inline), Op]
        public static SpanBlock256<byte> create(W256 w,
            byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7,
            byte x8, byte x9, byte xA, byte xB, byte xC, byte xD, byte xE, byte xF,
            byte x10, byte x11, byte x12, byte x13, byte x14, byte x15, byte x16, byte x17,
            byte x18, byte x19, byte x1A, byte x1B, byte x1C, byte x1D, byte x1E, byte x1F)
                => new SpanBlock256<byte>(x0,x1,x2,x3,x4,x5,x6,x7,x8,x9,xA,xB,xC,xD,xE,xF,
                    x10,x11,x12,x13,x14,x15,x16,x17,x18, x19,x1A,x1B,x1C,x1D,x1E,x1F);

        /// <summary>
        /// Creates a 256-bit blocked container from 16 16-bit cells
        /// </summary>
        [MethodImpl(Inline), Op]
        public static SpanBlock256<ushort> create(W256 n,
            ushort x0, ushort x1, ushort x2, ushort x3, ushort x4, ushort x5, ushort x6, ushort x7,
            ushort x8, ushort x9, ushort xA, ushort xB, ushort xC, ushort xD, ushort xE, ushort xF)
                => new SpanBlock256<ushort>(x0,x1,x2,x3,x4,x5,x6,x7,x8,x9,xA,xB,xC,xD,xE,xF);

        /// <summary>
        /// Creates a 256-bit blocked container from 8 32-bit cells
        /// </summary>
        [MethodImpl(Inline), Op]
        public static SpanBlock256<uint> create(W256 n,
            uint x0, uint x1, uint x2, uint x3, uint x4, uint x5, uint x6, uint x7)
                => new SpanBlock256<uint>(x0,x1,x2,x3,x4,x5,x6,x7);

        /// <summary>
        /// Creates a 256-bit blocked container from 4 64-bit cells
        /// </summary>
        [MethodImpl(Inline), Op]
        public static SpanBlock256<ulong> create(W256 n, ulong x0, ulong x1, ulong x2, ulong x3)
            => new SpanBlock256<ulong>(x0,x1,x2,x3);


        /// <summary>
        /// Creates a 512-bit blocked container from 8 64-bit cells
        /// </summary>
        [MethodImpl(Inline), Op]
        public static SpanBlock512<ulong> create(W512 w, ulong x0, ulong x1, ulong x2, ulong x3, ulong x4, ulong x5, ulong x6, ulong x7)
            => new SpanBlock512<ulong>(x0,x1,x2,x3,x4,x5,x6,x7);

        /// <summary>
        /// Creates a 512-bit blocked container from 16 32-bit cells
        /// </summary>
        [MethodImpl(Inline), Op]
        public static SpanBlock512<uint> create(W512 n,
            uint x0, uint x1, uint x2, uint x3, uint x4, uint x5, uint x6, uint x7,
            uint x8, uint x9, uint xA, uint xB, uint xC, uint xD, uint xE, uint xF)
                => new SpanBlock512<uint>(x0,x1,x2,x3,x4,x5,x6,x7,x8,x9,xA,xB,xC,xD,xE,xF);
    }
}
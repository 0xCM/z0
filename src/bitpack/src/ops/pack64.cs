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

    partial class BitPack
    {
        /// <summary>
        /// Packs 64 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ulong pack64x8x1<T>(in T src)
            where T : unmanaged
        {
            var dst = 0ul;
            dst = (ulong)pack32x8x1(src, n32, n8);
            dst |=(ulong)pack32x8x1(skip(src, 32), n32, n8) << 32;
            return dst;
        }

        /// <summary>
        /// Packs 64 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ulong pack64x8x1<T>(in SpanBlock512<T> src, int block)
            where T : unmanaged
                => pack64x8x1(src.BlockRef(block));

        /// <summary>
        /// Packs 64 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="count">The number of bits to pack</param>
        /// <param name="mod">The selection modulus</param>
        /// <param name="offset">The source offset</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ulong pack64x8x1<T>(ReadOnlySpan<T> src, N64 count, N8 mod, int offset)
            where T : unmanaged
                => pack64x8x1(skip(src, (uint)offset));
    }
}
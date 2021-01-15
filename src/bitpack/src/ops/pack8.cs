//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static BitMasks.Literals;
    using static BitMasks;
    using static z;

    partial class BitPack
    {
        /// <summary>
        /// Packs 8 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        [MethodImpl(Inline), Op]
        static byte pack8(ulong src)
            => (byte)gather(src, Lsb64x8x1);

        /// <summary>
        /// Packs 8 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="count">The number of bits to pack</param>
        /// <param name="mod">The selection modulus</param>
        /// <param name="offset">The source offset</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static byte pack8x8x1<T>(ReadOnlySpan<T> src, N8 count, N8 mod, int offset)
            where T : unmanaged
                => pack8(uint64(skip(src,(uint)offset)));

        /// <summary>
        /// Packs 8 1-bit values taken from the least significant bit of each source byte of an index-identified block
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mod">The bit selection modulus</param>
        /// <param name="block">The index of the block to pack</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static byte pack8x8x1<T>(in SpanBlock64<T> src, int block)
            where T : unmanaged
                => pack8(force<T,ulong>(src.BlockRef(block)));
    }
}
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
        /// Packs 16 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="n">The number of bits to pack</param>
        /// <param name="mod">The bit selection modulus</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ushort pack16x8x1<T>(in T src, N16 n, N8 mod)
            where T : unmanaged
                => vtakemask(gvec.vsll(cpu.vload(n128, z.view64u(src)),7));

        /// <summary>
        /// Pack 16 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The pack source</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ushort pack16x8x1<T>(in SpanBlock128<T> src, N8 mod, int block = 0)
            where T : unmanaged
                => pack16x8x1(src.BlockRef(block), n16, mod);

        /// <summary>
        /// Pack 16 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="count">The number of bits to pack</param>
        /// <param name="mod">The selection modulus</param>
        /// <param name="offset">The source offset</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ushort pack16x8x1<T>(ReadOnlySpan<T> src, N16 count, N8 mod, int offset = 0)
            where T : unmanaged
                => pack16x8x1(skip(src,(uint)offset), count, mod);
    }
}
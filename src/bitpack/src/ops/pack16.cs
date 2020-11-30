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
                => z.vtakemask(gvec.vsll(z.vload(n128, z.view64u(src)),7));

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

        /// <summary>
        /// Packs the least significant bit from 16 32-bit unsigned integers to a 16-bit target
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target value</param>
        [MethodImpl(Inline), Op]
        public static ref ushort pack16x32x1(in uint src, ref ushort dst)
        {
            var v0 = vload(n256, skip(src,0*8));
            var v1 = vload(n256, skip(src,1*8));
            dst = vpacklsb(vcompact(v0, v1, n128, z8));
            return ref dst;
        }
    }
}
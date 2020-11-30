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
        /// Packs 32 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="n">The number of bits to pack</param>
        /// <param name="mod">The bit selection modulus</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint pack32x8x1<T>(in T src, N32 n, N8 mod)
            where T : unmanaged
                => z.vtakemask(gvec.vsll(z.vload(n256, z.view64u(src)),7));

        /// <summary>
        /// Packs 32 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint pack32x8x1<T>(in SpanBlock256<T> src, N8 mod, int block = 0)
            where T : unmanaged
                => pack32x8x1(src.BlockRef(block), n32, mod);

        /// <summary>
        /// Packs 32 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="count">The number of bits to pack</param>
        /// <param name="mod">The selection modulus</param>
        /// <param name="offset">The source offset</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint pack32x8x1<T>(ReadOnlySpan<T> src, N32 count, N8 mod, int offset = 0)
            where T : unmanaged
                => pack32x8x1(skip(src,(uint)offset), count, mod);

        /// <summary>
        /// Packs the least significant bit from 32 32-bit unsigned integers to a 32-bit target
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target value</param>
        [MethodImpl(Inline), Op]
        public static ref uint pack32x32x1(in uint src, ref uint dst)
        {
            var v0 = vload(n256, skip(src,0*8));
            var v1 = vload(n256, skip(src,1*8));
            var x = vcompact(v0,v1,n256,z16);

            v0 = vload(n256, skip(src,2*8));
            v1 = vload(n256, skip(src,3*8));
            var y = vcompact(v0,v1,n256,z16);

            dst = vpacklsb(vcompact(x,y,n256,z8));
            return ref dst;
        }
    }
}
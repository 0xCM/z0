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

        /// <summary>
        /// Packs the least significant bit from 64 32-bit unsigned integers to a 64-bit target
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target value</param>
        [MethodImpl(Inline), Op]
        public static ref ulong pack64x32x1(in uint src, ref ulong dst)
        {
            var v0 = vload(n256, skip(src, 0*8));
            var v1 = vload(n256, skip(src, 1*8));
            var x = vcompact(v0, v1, n256, z16);

            v0 = vload(n256, skip(src,2*8));
            v1 = vload(n256, skip(src,3*8));
            var y = vcompact(v0, v1, n256, z16);

            var packed = (ulong)vpacklsb(vcompact(x,y,n256,z8));

            v0 = vload(n256, skip(src,4*8));
            v1 = vload(n256, skip(src,5*8));
            x = vcompact(v0,v1,n256,z16);

            v0 = vload(n256, skip(src,6*8));
            v1 = vload(n256, skip(src,7*8));
            y = vcompact(v0,v1,n256,z16);

            packed |= (ulong)vpacklsb(vcompact(x,y,n256,z8)) << 32;

            dst = packed;
            return ref dst;
        }
    }
}
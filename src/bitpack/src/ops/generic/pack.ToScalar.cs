//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static dvec;
    using static Konst;
    using static z;
    using static V0;
    using static BitMasks.Literals;

    partial class BitPack
    {
        /// <summary>
        /// Packs 8 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mod">The bit selection modulus</param>
        /// <param name="block">The index of the block to pack</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static byte pack<T>(in T src, N8 count, N8 mod)
            where T : unmanaged
                => (byte)Bits.gather(convert<T,ulong>(src), Lsb64x8x1);

        /// <summary>
        /// Packs 16 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="count">The number of bits to pack</param>
        /// <param name="mod">The bit selection modulus</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ushort pack<T>(in T src, N16 count, N8 mod)
            where T : unmanaged
                => vtakemask(gvec.vsll(vload(n128, As.view64u(src)),7));

        /// <summary>
        /// Packs 32 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="count">The number of bits to pack</param>
        /// <param name="mod">The bit selection modulus</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static uint pack<T>(in T src, N32 count, N8 mod)
            where T : unmanaged
                => vtakemask(gvec.vsll(vload(n256, As.view64u(src)),7));

        /// <summary>
        /// Packs 64 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="count">The number of bits to pack</param>
        /// <param name="mod">The bit selection modulus</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ulong pack<T>(in T src, N64 count, N8 mod)
            where T : unmanaged
        {
            var dst = 0ul;
            dst = (ulong)pack(src, n32, n8);
            dst |=(ulong)pack(skip(src, 32), n32, n8) << 32;
            return dst;
        }
    }
}
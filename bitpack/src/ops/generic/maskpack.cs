//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static dvec;
    using static Seed;
    using static Memories;
    using static Vectors;

    partial class BitPack
    {
        /// <summary>
        /// Packs 16 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="count">The number of bits to pack</param>
        /// <param name="mod">The bit selection modulus</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ushort maskpack<T>(in T src, N16 count, N8 mod)
            where T : unmanaged
                => vtakemask(gvec.vsll(vload(n128, refs.const64(src)),7));

        /// <summary>
        /// Packs 32 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="count">The number of bits to pack</param>
        /// <param name="mod">The bit selection modulus</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static uint maskpack<T>(in T src, N32 count, N8 mod)
            where T : unmanaged
                => vtakemask(gvec.vsll(vload(n256, refs.const64(src)),7));

        /// <summary>
        /// Packs 64 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="count">The number of bits to pack</param>
        /// <param name="mod">The bit selection modulus</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ulong maskpack<T>(in T src, N64 count, N8 mod)
            where T : unmanaged
        {
            var dst = 0ul;
            dst = (ulong)maskpack(in src, n32, n8);
            dst |=(ulong)maskpack(in skip(in src, 32), n32, n8) << 32;
            return dst;
        }        
    }
}
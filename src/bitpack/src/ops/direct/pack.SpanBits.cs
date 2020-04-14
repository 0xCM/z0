//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static Seed;
    using static Memories;
    using static Vectors;

    partial class BitPack
    {
        /// <summary>
        /// Packs the leading 8 source bits
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="count">The number of bits to pack</param>
        [MethodImpl(Inline), Op]
        public static byte pack(Span<bit> src, N8 count)
        {
            var v0 = vload(n256, head(convert(src, 0, bitsize<byte>())));
            return (byte)packlsb(dvec.vcompact(v0,n128,z8), n8);
        }

        /// <summary>
        /// Packs the 16 leading source bits
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="count">The number of bits to pack</param>
        [MethodImpl(Inline), Op]
        public static ushort pack(Span<bit> src, N16 count)
        {
            ref readonly var unpacked = ref head(convert(src, 0, bitsize<ushort>())); 
            return pack(unpacked, count, w16);
        }

        /// <summary>
        /// Packs the 32 leading source bits
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="count">The number of bits to pack</param>
        [MethodImpl(Inline), Op]
        public static uint pack(Span<bit> src, N32 count)
        {
            ref readonly var unpacked = ref head(convert(src, 0, bitsize<uint>()));
            return pack(unpacked,count, w32);            
        }

        /// <summary>
        /// Packs the 64 leading source bits
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="count">The number of bits to pack</param>
        [MethodImpl(Inline), Op]
        public static ulong pack(Span<bit> src, N64 count)
        {
            ref readonly var unpacked = ref head(convert(src, 0, bitsize<ulong>()));
            return pack(unpacked, count, w64);
        }
    }
}
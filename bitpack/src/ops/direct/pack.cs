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

        /// <summary>
        /// Packs the least significant bit from 8 32-bit unsigned integers to an 8-bit target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="count">The target width selector</param>
        [MethodImpl(Inline), Op]
        public static byte pack(in uint src, N8 count, W8 dst)
        {
            var v0 = vload(n256, skip(src,0*8));
            return (byte)packlsb(dvec.vcompact(v0, n128, z8),n8);            
        }

        /// <summary>
        /// Packs the least significant bit from 16 32-bit unsigned integers to a 16-bit target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="count">The target width selector</param>
        [MethodImpl(Inline), Op]
        public static ushort pack(in uint src, N16 count, W16 dst)
        {
            var v0 = vload(n256, skip(src,0*8));
            var v1 = vload(n256, skip(src,1*8));
            return packlsb(dvec.vcompact(v0, v1, n128, z8), n8);
        }

        /// <summary>
        /// Packs the least significant bit from 32 32-bit unsigned integers to a 32-bit target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="count">The target width selector</param>
        [MethodImpl(Inline), Op]
        public static uint pack(in uint src, N32 count, W32 dst)
        {            
            var v0 = vload(n256, skip(src,0*8));
            var v1 = vload(n256, skip(src,1*8));
            var x = dvec.vcompact(v0,v1,n256,z16);

            v0 = vload(n256, skip(src,2*8));
            v1 = vload(n256, skip(src,3*8));
            var y = dvec.vcompact(v0,v1,n256,z16);

            return packlsb(dvec.vcompact(x,y,n256,z8), n8);
        }

        /// <summary>
        /// Packs the least significant bit from 64 32-bit unsigned integers to a 64-bit target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="count">The target width selector</param>
        [MethodImpl(Inline), Op]
        public static ulong pack(in uint src, N64 count, W64 dst)
        {
            var v0 = vload(n256, skip(src,0*8));
            var v1 = vload(n256, skip(src,1*8));
            var x = dvec.vcompact(v0,v1,n256,z16);

            v0 = vload(n256, skip(src,2*8));
            v1 = vload(n256, skip(src,3*8));
            var y = dvec.vcompact(v0,v1,n256,z16);

            var packed = (ulong)packlsb(dvec.vcompact(x,y,n256,z8), n8);

            v0 = vload(n256, skip(src,4*8));
            v1 = vload(n256, skip(src,5*8));
            x = dvec.vcompact(v0,v1,n256,z16);

            v0 = vload(n256, skip(src,6*8));
            v1 = vload(n256, skip(src,7*8));
            y = dvec.vcompact(v0,v1,n256,z16);

            packed |= (ulong)packlsb(dvec.vcompact(x,y,n256,z8), n8) << 32;

            return packed;
        }

        [MethodImpl(Inline)]
        static Span<uint> convert(Span<bit> src, int offset, int count)
           => src.Slice(offset, count).As<bit,uint>();
    }
}
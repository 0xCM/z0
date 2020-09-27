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
        /// Packs the least significant bit from 8 32-bit unsigned integers to an 8-bit target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="count">The number of bits to pack</param>
        /// <param name="dst">The target width</param>
        [MethodImpl(Inline), Op]
        public static byte pack(in uint src, N8 count, W8 dst)
        {
            var v0 = vload(n256, skip(src,0*8));
            return (byte)packlsb(z.vcompact(v0, n128, z8),n8);
        }

        /// <summary>
        /// Packs the least significant bit from 16 32-bit unsigned integers to a 16-bit target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="count">The number of bits to pack</param>
        /// <param name="dst">The target width</param>
        [MethodImpl(Inline), Op]
        public static ushort pack(in uint src, N16 count, W16 dst)
        {
            var v0 = vload(n256, skip(src,0*8));
            var v1 = vload(n256, skip(src,1*8));
            return packlsb(z.vcompact(v0, v1, n128, z8), n8);
        }

        /// <summary>
        /// Packs the least significant bit from 32 32-bit unsigned integers to a 32-bit target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="count">The number of bits to pack</param>
        /// <param name="dst">The target width</param>
        [MethodImpl(Inline), Op]
        public static uint pack(in uint src, N32 count, W32 dst)
        {
            var v0 = vload(n256, skip(src,0*8));
            var v1 = vload(n256, skip(src,1*8));
            var x = z.vcompact(v0,v1,n256,z16);

            v0 = vload(n256, skip(src,2*8));
            v1 = vload(n256, skip(src,3*8));
            var y = z.vcompact(v0,v1,n256,z16);

            return packlsb(z.vcompact(x,y,n256,z8), n8);
        }

        /// <summary>
        /// Packs the least significant bit from 64 32-bit unsigned integers to a 64-bit target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="count">The number of bits to pack</param>
        /// <param name="dst">The target width</param>
        [MethodImpl(Inline), Op]
        public static ulong pack(in uint src, N64 count, W64 dst)
        {
            var v0 = vload(n256, skip(src,0*8));
            var v1 = vload(n256, skip(src,1*8));
            var x = z.vcompact(v0,v1,n256,z16);

            v0 = vload(n256, skip(src,2*8));
            v1 = vload(n256, skip(src,3*8));
            var y = z.vcompact(v0,v1,n256,z16);

            var packed = (ulong)packlsb(z.vcompact(x,y,n256,z8), n8);

            v0 = vload(n256, skip(src,4*8));
            v1 = vload(n256, skip(src,5*8));
            x = z.vcompact(v0,v1,n256,z16);

            v0 = vload(n256, skip(src,6*8));
            v1 = vload(n256, skip(src,7*8));
            y = z.vcompact(v0,v1,n256,z16);

            packed |= (ulong)packlsb(z.vcompact(x,y,n256,z8), n8) << 32;

            return packed;
        }

        [MethodImpl(Inline)]
        static Span<uint> convert(Span<bit> src, int offset, int count)
           => src.Slice(offset, count).Cast<bit,uint>();
    }
}
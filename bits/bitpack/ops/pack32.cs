//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static Root;    
    using static Nats;
    using static vgeneric;

    partial class BitPack
    {
        /// <summary>
        /// Packs the least significant bit from 8 32-bit unsigned integers to an 8-bit target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="n">The target width selector</param>
        [MethodImpl(Inline), Op]
        public static byte pack32(in uint src, N8 n)
        {
            var v0 = vload(n256, skip(src,0*8));
            return (byte)BitPack.packlsb8(dvec.vcompact(v0, n128, z8));
        }

        /// <summary>
        /// Packs the least significant bit from 16 32-bit unsigned integers to a 16-bit target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="n">The target width selector</param>
        [MethodImpl(Inline), Op]
        public static ushort pack32(in uint src, N16 n)
        {
            var v0 = vload(n256, skip(src,0*8));
            var v1 = vload(n256, skip(src,1*8));
            return BitPack.packlsb8(dvec.vcompact(v0, v1, n128, z8));
        }

        /// <summary>
        /// Packs the least significant bit from 32 32-bit unsigned integers to a 32-bit target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="n">The target width selector</param>
        [MethodImpl(Inline), Op]
        public static uint pack32(in uint src, N32 n)
        {            
            var v0 = vload(n256, skip(src,0*8));
            var v1 = vload(n256, skip(src,1*8));
            var x = dvec.vcompact(v0,v1,n256,z16);

            v0 = vload(n256, skip(src,2*8));
            v1 = vload(n256, skip(src,3*8));
            var y = dvec.vcompact(v0,v1,n256,z16);

            return BitPack.packlsb8(dvec.vcompact(x,y,n256,z8));
        }

        /// <summary>
        /// Packs the least significant bit from 64 32-bit unsigned integers to a 64-bit target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="n">The target width selector</param>
        [MethodImpl(Inline), Op]
        public static ulong pack32(in uint src, N64 n)
        {
            var v0 = vload(n256, skip(src,0*8));
            var v1 = vload(n256, skip(src,1*8));
            var x = dvec.vcompact(v0,v1,n256,z16);

            v0 = vload(n256, skip(src,2*8));
            v1 = vload(n256, skip(src,3*8));
            var y = dvec.vcompact(v0,v1,n256,z16);

            var packed = (ulong)packlsb8(dvec.vcompact(x,y,n256,z8));

            v0 = vload(n256, skip(src,4*8));
            v1 = vload(n256, skip(src,5*8));
            x = dvec.vcompact(v0,v1,n256,z16);

            v0 = vload(n256, skip(src,6*8));
            v1 = vload(n256, skip(src,7*8));
            y = dvec.vcompact(v0,v1,n256,z16);

            packed |= (ulong)packlsb8(dvec.vcompact(x,y,n256,z8)) << 32;

            return packed;
        }
    }
}
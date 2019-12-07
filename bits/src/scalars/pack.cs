//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static zfunc;
    using static As;

    partial class Bits
    {         
        /// <summary>
        /// Consecutively packs the first bit of each source byte into an 8-bit target
        /// dst := [bit(0, src[0]), bit(0, src[1]), ... bit(0, src[15])]
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline)]
        public static byte pack8x1(in ConstBlock64<byte> src)
            => (byte) dinx.gather(head64(src), BitMasks.Lsb64x8x1);

        /// <summary>
        /// Consecutively packs the first bit of each source byte into a 16-bit target
        /// dst := [bit(0, src[0]), bit(0, src[1]), ... bit(0, src[15])]
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline)]
        public static ushort pack8x1(in ConstBlock128<byte> src)
            => (ushort) dinx.vtakemask(dinx.vsll(v64u(src.LoadVector()),7));            

        /// <summary>
        /// Consecutively packs the first bit of each source byte into a 32-bit target
        /// dst := [bit(0, src[0]), bit(0, src[1]), ... bit(0, src[31])]
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline)]
        public static uint pack8x1(in ConstBlock256<byte> src)
            => dinx.vtakemask(dinx.vsll(v64u(src.LoadVector()),7));            

        /// <summary>
        /// Packs a 128-bit block into a 64-bit integer by selecting the lower 4 bits of each 8-bit cell
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="block">The block index</param>
        [MethodImpl(Inline)]
        public static ulong pack16x4(in ConstBlock128<byte> src, int block = 0)
        {
            const int length = 16;
            const int seglen = 4;
            const int mask = length - 1;
            
            var terms = src.Block(block);
            var dst = 0ul;
            for(var i=0; i<length; i++)
                dst |= (((ulong)terms[i] << i*seglen) & mask);
            return dst;
            
        }

    }
}
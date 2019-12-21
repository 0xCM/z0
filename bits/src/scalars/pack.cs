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
    using static AsIn;

    partial class Bits
    {         
        /// <summary>
        /// Consecutively packs the first bit of each source byte into the lower 4 bits of an 8-bit target
        /// dst := [bit(0, src[0]), bit(0, src[1]), ... bit(0, src[3])]
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline)]
        public static byte pack8x1(in ConstBlock32<byte> src)
            => (byte) Bits.gather(uint32(in src.Head), BitMasks.Lsb32x8);

        /// <summary>
        /// Consecutively packs the first bit of each source byte into an 8-bit target
        /// dst := [bit(0, src[0]), bit(0, src[1]), ... bit(0, src[7])]
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline)]
        public static byte pack8x1(in ConstBlock64<byte> src)
            => (byte) Bits.gather(uint64(in src.Head), BitMasks.Lsb64x8);

        /// <summary>
        /// Consecutively packs the first bit of each source byte into a 16-bit target
        /// dst := [bit(0, src[0]), bit(0, src[1]), ... bit(0, src[15])]
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline)]
        public static ushort pack8x1(in ConstBlock128<byte> src)
            => dinx.vtakemask(dinx.vsll(v64u(src.LoadVector()),7));            

        /// <summary>
        /// Consecutively packs the first bit of each source byte into a 32-bit target
        /// dst := [bit(0, src[0]), bit(0, src[1]), ... bit(0, src[31])]
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline)]
        public static uint pack8x1(in ConstBlock256<byte> src)
            => dinx.vtakemask(dinx.vsll(v64u(src.LoadVector()),7));            

    }
}
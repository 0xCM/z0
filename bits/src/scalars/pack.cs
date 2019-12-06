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
    }
}
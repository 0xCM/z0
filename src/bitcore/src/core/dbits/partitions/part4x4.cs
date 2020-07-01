//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Konst;
    using static As;
    using static Typed;
       
    partial class Bits
    {
        /// <summary>
        /// Partitions a 16-bit source value into 4 8-bit target segments
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline), Op]
        public static ref byte part4x4(ushort src, ref byte dst)
        {
            const uint M = BitMasks.Lsb32x8x4;
            seek32(dst, 0) = scatter(src, M); 
            return ref dst;
        }
    }
}
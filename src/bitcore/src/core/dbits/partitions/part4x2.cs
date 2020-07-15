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
       
    partial class Bits
    {
        /// <summary>
        /// Partitions an 8-bit source value into 2 target segments each with an effective width of 4
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline), Op]
        public static ref byte part4x2(uint src, ref byte dst)
        {
            const uint M = BitMasks.Lsb8x8x4;

            seek(dst, 0) = (byte)((src >> 0) & M);
            seek(dst, 1) = (byte)((src >> 4) & M);
            return ref dst;
        }
    }
}
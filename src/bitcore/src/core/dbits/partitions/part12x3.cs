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
        /// Partitions the first 12 bits of a 32-bit source into 4 target segments each with an effective width of 3
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline), Op]
        public static ref byte part12x3(uint src, ref byte dst)
        {
            const uint M = BitMasks.Lsb8x8x3;

            part9x3(src, ref dst);
            seek(dst, 3) = (byte)(src >> 9 & M);
            return ref dst;
        }
    }
}
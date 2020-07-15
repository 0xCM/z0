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
        /// Partitions the first 24 bits of a 32-bit source value into 9 8-bit target segments
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline), Op]
        public static ref byte part24x3(uint src, ref byte dst)
        {
            seek64(dst, 0) = Bits.scatter(src, BitMasks.Lsb64x8x3); 
            return ref dst;
        }    
    }
}
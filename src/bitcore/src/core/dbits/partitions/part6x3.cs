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
        /// Partitions the first 6 bits of a 32-bit source value into 2 target segments each with an effective width of 3
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target memory location</param>
        [MethodImpl(Inline), Op]
        public static ref byte part6x3(uint src, ref byte dst)
        {
            const uint M = BitMasks.Lsb8x8x3;

            seek(dst, 0) = (byte)(src >> 0 & M);
            seek(dst, 1) = (byte)(src >> 3 & M);
            return ref dst;
        }
    }
}
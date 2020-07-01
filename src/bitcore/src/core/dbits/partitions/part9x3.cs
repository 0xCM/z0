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
        /// Partitions the first 9 bits of a 32-bit source value into 3 target segments each with an effective width of 3
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        [MethodImpl(Inline), Op]
        public static ref byte part9x3(uint src, ref byte dst)
        {
            const uint M = BitMasks.Lsb8x8x3;

            part6x3(src, ref dst);
            seek(dst, 2) = (byte)(src >> 6 & M);
            return ref dst;
        }
    }
}
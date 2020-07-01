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
        /// Partitions a 16-bit source into 8 target segments each with an effective width of 2
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target memory location</param>
        [MethodImpl(Inline), Op]
        public static ref byte part16x2(ushort src, ref byte dst)
        {
            part8x2((byte)src, ref dst);
            part8x2((byte)(src >> 8), ref seek(dst, 4));
            return ref dst;
        }
    }
}
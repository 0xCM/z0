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

    partial class Bits
    {
        /// <summary>
        /// Partitions a 64-bit source value into 4 segments of width 16
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline), Op]
        public static ref ushort part64x16(ulong src, ref ushort dst)
        {
            seek64(dst, 0) = src; 
            return ref dst;
        }
    }
}
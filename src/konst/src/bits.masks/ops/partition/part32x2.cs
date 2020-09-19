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

    partial class BitMasks
    {
        /// <summary>
        /// Partitions a 32-bit source into 16 target segments each with an effective width of 2
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline), Op]
        public static ref byte part32x2(uint src, ref byte dst)
        {
            part16x2((ushort)src, ref dst);
            part16x2((ushort)(src >> 16), ref seek(dst, 8));
            return ref dst;
        }
    }
}
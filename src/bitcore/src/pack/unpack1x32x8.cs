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
        /// Unpacks 8 source bits over 8 32-bit target segments
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="buffer">The intermediate buffer</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack1x32x8(byte src, Span<uint> dst)
        {
            var buffer = z64;
            ref var tmp = ref uint8(ref buffer);
            ref var lead = ref first(dst);
            unpack1x8x8(src, ref tmp);
            vconvert(n64, in tmp, n256, n32).StoreTo(ref lead);
        }
    }
}
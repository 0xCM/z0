//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class BitSpans
    {
        [MethodImpl(Inline), Op]
        public static BitSpan32 trim32(in BitSpan32 src)
        {
            var pos = msb32(src);
            if(pos != 0 && pos != src.Length - 1)
                return BitSpans.load32(src.Data.Slice(0, pos + 1));
            else
                return src;
        }
    }
}